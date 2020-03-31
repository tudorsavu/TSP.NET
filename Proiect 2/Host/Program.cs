using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using ObjectWCF;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lansare server WCF...");
            using (ServiceHost host = new ServiceHost(typeof(PhotosAndProperties), new Uri("http://localhost:4000/PC")))
            {
                host.Open();

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);


                Console.WriteLine("Server in executie la http://localhost:4000/PC. Se asteapta conexiuni...");
                Console.WriteLine("Apasati Enter pentru a opri serverul!");
                Console.ReadKey();
                host.Close();
            }


        }
    }
}