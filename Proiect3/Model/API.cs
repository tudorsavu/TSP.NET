using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    public class Api
    {
        private readonly Model1Container _ctx;

        public Api()
        {
            _ctx = new Model1Container();
        }

        public List<Properties> GetProperties()
        {
            return _ctx.Properties.ToList();
        }

        public List<Photos> GetPhotos()
        {
            return _ctx.Photos.ToList();
        }

        public List<string> GetPhotoPaths()
        {
            return _ctx.Photos.Select(p => p.Path).ToList();
        }

        public bool AddNewPhoto(string path, DateTime date)
        {
            if (!_ctx.Photos.Any(p => p.Path == path))
            {
                var photo = new Photos()
                {
                    Date = date,
                    Path = path,
                };

                _ctx.Photos.Add(photo);
                _ctx.SaveChanges();
                return true;
            }
            return false;

        }

        public DateTime GetDateTimeByPath(string path)
        {
            return _ctx.Photos.Where(p => p.Path == path).Select(p => p.Date).First();
        }

        public List<Photos> GetPhotosByPropertyName(string name)
        {
            var properties = _ctx.Properties.Where(pr => pr.Property_name == name).ToList();
            
            var result = new List<Photos>(properties.Count);
            foreach (var prop in properties)
            {
                result.Add(_ctx.Photos.Single(p => p.Id == prop.PhotosId));
            }

            return result;
        }

        public Dictionary<string, string> GetPropertiesByPath(string path)
        {
            var properties = from prop in _ctx.Properties
                join photo in _ctx.Photos on prop.PhotosId equals photo.Id
                where photo.Path == path
                select new {prop.Property_name, prop.Property_desc};

            return properties.ToDictionary(p => p.Property_name, p => p.Property_desc); 
        }

        public int GetPhotoIdByPath(string path)
        {
            return _ctx.Photos.Where(p => p.Path == path).Select(p => p.Id).First();
        }

        public void AddProperties(List<Tuple<string, string>> newProperties, int photoId)
        {
            foreach (var tuple in newProperties)
            {
                var propertyPair = new Properties()
                {
                    Property_name = tuple.Item1,
                    Property_desc = tuple.Item2,
                    PhotosId = photoId
                };

                _ctx.Properties.Add(propertyPair);
                _ctx.SaveChanges();
            }
        }

        public List<string> GetSortedListByDate(DateTime date)
        {
            var dict = new Dictionary<string, double>();

            foreach (var photo in _ctx.Photos)
            {
                dict.Add(photo.Path, Math.Abs((date-photo.Date).TotalDays));
            }

            var sortedPaths = from pair in dict
                orderby pair.Value ascending
                select pair.Key;

            return sortedPaths.ToList();
        }

        public void RemoveBtPath(string path)
        {
            var photoToDelete = _ctx.Photos.Where(p => p.Path == path).First();
            var properties = from prop in _ctx.Properties
                join photo in _ctx.Photos on prop.PhotosId equals photo.Id
                where photo.Path == path
                select prop;
            foreach (var prop in properties)
            {
                _ctx.Properties.Remove(prop);
            }

            _ctx.Photos.Remove(photoToDelete);
            _ctx.SaveChanges();
        }
    }
}
