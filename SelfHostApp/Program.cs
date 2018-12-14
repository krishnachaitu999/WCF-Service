using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using _21_WCFAssignment_1DOTNET_Task1;
namespace SelfHostApp
{
    class Program
    {
        static void Main(string[] args)
        {  //Create a URI to serve as the base address
            Uri httpUrl = new Uri("http://localhost:53972/Service.svc");
            //Create ServiceHost
            ServiceHost HttpHost = new ServiceHost(typeof(_21_WCFAssignment_1DOTNET_Task1.Service1), httpUrl);
            //Add a service endpoint
            HttpHost.AddServiceEndpoint(typeof(_21_WCFAssignment_1DOTNET_Task1.IService), new BasicHttpBinding(), "");
            //Enable metadata exchange
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            HttpHost.Description.Behaviors.Add(smb);
            //Start the Service
            HttpHost.Open();
            Console.WriteLine("HTTP Service is host at " + DateTime.Now.ToString());
            Console.WriteLine("HTTP Host is running... Press <Enter> key to stop");
            //ServiceHost TCPhost = new ServiceHost(typeof(_21_WCFAssignment_1DOTNET_Task1.Service1));
            //TCPhost.AddServiceEndpoint(typeof(_21_WCFAssignment_1DOTNET_Task1.IService), new NetTcpBinding(), new Uri("net.tcp://localhost:808/Service"));
            //TCPhost.Open();
            Console.WriteLine("TCP Service is host at " + DateTime.Now.ToString());
            Console.WriteLine("TCP Host is running... Press <Enter> key to stop");
            Console.ReadLine();
        }
    }
}
