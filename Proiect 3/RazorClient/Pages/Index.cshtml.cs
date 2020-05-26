using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PhotoPropsService;

namespace Proiect3.Pages
{
    public class IndexModel : PageModel
    {

        public string SelectedProperty;

        private PhotosAndPropertiesClient client;
        public Photos[] photos;
        public Properties[] properties;
        public List<string> photoPaths;
        public List<string> propertyNames;

        public void OnGet()
        {
            PhotosAndPropertiesClient client = new PhotosAndPropertiesClient(new PhotosAndPropertiesClient.EndpointConfiguration());

            properties = client.GetPropertiesAsync().Result;
            propertyNames = new List<string>(properties.Length);

            photos = client.GetPhotosAsync().Result;
            
            GetImagesWebPaths();

            GetPropertyNames();


        }

        public void OnPost(string selectedProp)
        {

            SelectedProperty = selectedProp;
            
            client = new PhotosAndPropertiesClient(new PhotosAndPropertiesClient.EndpointConfiguration());

            photos = client.GetPhotosByPropertyNameAsync(selectedProp).Result;

            GetImagesWebPaths();

            properties = client.GetPropertiesAsync().Result;
            propertyNames = new List<string>(properties.Length);

            GetPropertyNames();

        }

        public void GetPropertyNames() 
        {
            
            foreach (var property in properties)
            {
                if (!propertyNames.Contains(property.Property_name))
                {
                    propertyNames.Add(property.Property_name);
                }
            }
            propertyNames = propertyNames.OrderBy(name => name).ToList();
        }
        public void GetImagesWebPaths() // using local server because my browser won't use local resources 
        {
            photoPaths = new List<string>(photos.Length);

            foreach (var photo in photos)
            {
                photoPaths.Add("http://127.0.0.1:8887/" + Path.GetFileName(photo.Path));
            }
        }
    }
}
