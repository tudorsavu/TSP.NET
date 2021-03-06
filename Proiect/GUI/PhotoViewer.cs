﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Model;

namespace Proiect1
{
    public partial class PhotoViewer : Form
    {
        private readonly Api _api;
        private int _imgCount;
        private List<Tuple<string, string>> _newProperties;
        private DateTime _sortingDateTime;
       
        public PhotoViewer()
        {
            _imgCount = 0;
            _api = new Api();
            InitializeComponent();
            LoadPhotosOnStart();

        }

        public void LoadPhoto(string path) // loads/appends photo into the listview
        {
            FileInfo fi = new FileInfo(path);
            using (FileStream stream = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read))
            {
                imageList1.Images.Add(Image.FromStream(stream));
            }
            listView1.LargeImageList = imageList1;
            listView1.Items.Add(new ListViewItem
            {
                ImageIndex = _imgCount,
                Text = fi.Name,
                Tag = fi.FullName
            });
            _imgCount++;
        }

        public void LoadPhotosOnStart() // loads currently existing photos from db
        {
            
            var photoPaths = _api.GetPhotoPaths();
            imageList1.ImageSize = new Size(50, 50);
            if (photoPaths.Count > 0)
            {
                foreach (var path in photoPaths)
                {
                    LoadPhoto(path);
                }
            }
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter =
                @"Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                @"All files (*.*)|*.*";
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = @"Select Photos";
            openFileDialog1.FileName = "";
            imageList1.ImageSize = new Size(50, 50);

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                foreach (var path in openFileDialog1.FileNames)
                {
                    DateTime imgDateTime= new DateTime();

                    using (NewImgPrompt formImgPrompt = new NewImgPrompt(path))
                    {
                        if (formImgPrompt.ShowDialog() == DialogResult.OK)
                        {
                            imgDateTime = formImgPrompt.GetDate();
                        }
                    }
                    if (!_api.AddNewPhoto(path,imgDateTime))
                    {
                        MessageBox.Show(@"Photo path already in DB!");
                    }
                    else
                    {
                        LoadPhoto(path);
                    }
                }
            }
        }

        private void listview1_Click(object sender, EventArgs e)
        {
            var path = listView1.SelectedItems[0].Tag.ToString();
            var date = _api.GetDateTimeByPath(path);
            var properties = _api.GetPropertiesByPath(path);
            var photoId = _api.GetPhotoIdByPath(path);
            bool removed = false;
            using (SelectedImgForm form = new SelectedImgForm(path, date, properties))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _newProperties = form.GetPropertiesTuples();
                    _api.AddProperties(_newProperties,photoId);
                    removed = form.Removed();

                }
            }

            if (removed)
            {
                _api.RemoveBtPath(path);
                RemoveListviewItms();
                LoadPhotosOnStart();
            }
        }

        private void RemoveListviewItms()
        {
            imageList1 = new ImageList();
            imageList1.ImageSize = new Size(50, 50);
            _imgCount = 0;  // works as index for the listview items
            foreach (ListViewItem item in listView1.Items)
            {
                listView1.Items.Remove(item);
            }
        }
        private void SortBtn_Click(object sender, EventArgs e)
        {
            using (DateSortForm form = new DateSortForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _sortingDateTime = form.GetDateTime();
                }
            }
            RemoveListviewItms();
            foreach (var path in _api.GetSortedListByDate(_sortingDateTime))
            {
                LoadPhoto(path);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RemoveListviewItms();
            LoadPhotosOnStart();
        }
    }
}
