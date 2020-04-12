using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect1
{
    class SelectedImgForm : Form
    {
        private Label PhotoLabel;
        private Label DateLabel;
        private Label Date;
        private Button okBtn;
        private PictureBox pictureBox;
        private Button AddPropertyBtn;
        private List<Tuple<string,string>> propertiesTuples;
        private Button RemoveBtn;
        private int position = 85;
        private string _photoPath;
        private bool remove;

        public List<Tuple<string, string>> GetPropertiesTuples()
        {
            return propertiesTuples;
        }

        public SelectedImgForm(string path, DateTime date, Dictionary<string,string> properties)
        {
            InitializeComponent();
            LoadProperties(properties);
            _photoPath = path;
            PhotoLabel.Text = path;
            pictureBox.Image = new Bitmap(path);
            Date.Text = date.ToString();
            propertiesTuples = new List<Tuple<string, string>>();
            remove = false;


        }

        public bool Removed()
        {
            return remove;
        }

    private void AddPropertiesLabels(string name, string description)
        {
            position += 20;
            Label nameLabel = new Label();
            Label descLabel = new Label();
            descLabel.Text = description;
            nameLabel.Text = name + ":";
            descLabel.Location = new Point(750, position);
            nameLabel.Location = new Point(650, position);
            this.Controls.Add(descLabel);
            this.Controls.Add(nameLabel);
        }

        private void LoadProperties(Dictionary<string,string> propertiesFromDB)
        {
            foreach (KeyValuePair<string,string> entry in propertiesFromDB)
            {
                AddPropertiesLabels(entry.Key,entry.Value);
            }
        }

        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.PhotoLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.AddPropertyBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(49, 85);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(529, 338);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // PhotoLabel
            // 
            this.PhotoLabel.AutoSize = true;
            this.PhotoLabel.Location = new System.Drawing.Point(46, 40);
            this.PhotoLabel.Name = "PhotoLabel";
            this.PhotoLabel.Size = new System.Drawing.Size(80, 17);
            this.PhotoLabel.TabIndex = 1;
            this.PhotoLabel.Text = "PhotoLabel";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(650, 85);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(42, 17);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Date:";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(750, 85);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(36, 17);
            this.Date.TabIndex = 3;
            this.Date.Text = "date";
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.Location = new System.Drawing.Point(464, 457);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(114, 70);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // AddPropertyBtn
            // 
            this.AddPropertyBtn.Location = new System.Drawing.Point(314, 457);
            this.AddPropertyBtn.Name = "AddPropertyBtn";
            this.AddPropertyBtn.Size = new System.Drawing.Size(114, 70);
            this.AddPropertyBtn.TabIndex = 5;
            this.AddPropertyBtn.Text = "New Property";
            this.AddPropertyBtn.UseVisualStyleBackColor = true;
            this.AddPropertyBtn.Click += new System.EventHandler(this.AddPropertyBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.ForeColor = System.Drawing.Color.Crimson;
            this.RemoveBtn.Location = new System.Drawing.Point(49, 458);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(105, 70);
            this.RemoveBtn.TabIndex = 6;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // SelectedImgForm
            // 
            this.ClientSize = new System.Drawing.Size(994, 561);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddPropertyBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.PhotoLabel);
            this.Controls.Add(this.pictureBox);
            this.Name = "SelectedImgForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void okBtn_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AddPropertyBtn_Click(object sender, EventArgs e)
        {
            Tuple<string, string> property = new Tuple<string, string>("", "");

            using (NewPropertyForm form = new NewPropertyForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    property = form.GetTxtValues();
                    AddPropertiesLabels(property.Item1,property.Item2);
                    propertiesTuples.Add(property);
                }
            }

        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            remove = true;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
