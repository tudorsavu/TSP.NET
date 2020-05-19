using System;
using System.Collections.Generic;
using Model;

namespace ObjectWCF
{
    public class PhotosAndProperties : IPhotosAndProperties
    {
        private Api _api;

        public PhotosAndProperties()
        {
            _api= new Api();
        }
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

        public List<Properties> GetProperties()
        {
            return _api.GetProperties();
        }

        public void AddProperties(List<Tuple<string, string>> newProperties, int photoId)
        {
            _api.AddProperties(newProperties, photoId);
        }

        public Dictionary<string, string> GetPropertiesByPath(string path)
        {
            return  _api.GetPropertiesByPath(path);
        }

        public List<Photos> GetPhotosByPropertyName(string name)
        {
            return _api.GetPhotosByPropertyName(name);
        }


        public string Message(string name)
        {
            return name;
        }
    }
}
