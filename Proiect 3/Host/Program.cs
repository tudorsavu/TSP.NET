using System;
using System.ServiceModel;
using ObjectWCF;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lansare server WCF...");
            using (ServiceHost host = new ServiceHost(typeof(PhotosAndProperties)))
            {
                host.Open();

                Console.WriteLine("Server in executie la http://localhost:4000/. Se asteapta conexiuni...");
                Console.ReadKey();
                host.Close();
            }


        }
    }
}