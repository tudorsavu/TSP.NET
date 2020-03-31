using System;
using System.Collections.Generic;
using System.ServiceModel;
using Model;

namespace ObjectWCF
{
    [ServiceContract]
    interface IPhotos
    {
        [OperationContract]
        bool AddNewPhoto(string path, DateTime date);

        [OperationContract]
        DateTime GetDateTimeByPath(string path);

        [OperationContract]
        List<Photos> GetPhotos();

        [OperationContract]
        List<string> GetPhotoPaths();

        [OperationContract]
        int GetPhotoIdByPath(string path);

        [OperationContract]
        List<string> GetSortedListByDate(DateTime date);

        [OperationContract]
        void RemoveBtPath(string path);
    }

    [ServiceContract]
    interface IProperties
    {
        [OperationContract]
        void AddProperties(List<Tuple<string, string>> newProperties, int photoId);

        [OperationContract]
        Dictionary<string, string> GetPropertiesByPath(string path);

    }
    [ServiceContract]
    interface IPhotosAndProperties : IPhotos, IProperties
    {
        [OperationContract]
        string Message();
    }
}
