using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ObjectWCF
{
    class PhotosAndProperties : IPhotosAndProperties
    {
        private Api _api;
        public bool AddNewPhoto(string path, DateTime date)
        {
            return _api.AddNewPhoto(path, date);
        }

        public DateTime GetDateTimeByPath(string path)
        {
            return _api.GetDateTimeByPath(path);
        }

        public List<Photos> GetPhotos()
        {
            return _api.GetPhotos();
        }

        public List<string> GetPhotoPaths()
        {
            return _api.GetPhotoPaths();
        }

        public int GetPhotoIdByPath(string path)
        {
            return _api.GetPhotoIdByPath(path);
        }

        public List<string> GetSortedListByDate(DateTime date)
        {
            return _api.GetSortedListByDate(date);
        }

        public void RemoveBtPath(string path)
        {
            _api.RemoveBtPath(path);
        }

        public void AddProperties(List<Tuple<string, string>> newProperties, int photoId)
        {
            _api.AddProperties(newProperties, photoId);
        }

        public Dictionary<string, string> GetPropertiesByPath(string path)
        {
            return _api.GetPropertiesByPath(path);
        }
    }
}
