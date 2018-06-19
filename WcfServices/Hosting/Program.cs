using Contracts;
using Services;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            HostCalculatorServiceViaCode();
        }

        static void HostCalculatorServiceSimple()
        {
            // 1.使用代码配置终结点
            //using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
            //{
            //    host.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "http://127.0.0.1:9000/CalculatorService");
            //    if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
            //    {
            //        ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
            //        behavior.HttpGetEnabled = true;
            //        behavior.HttpGetUrl = new Uri("http://127.0.0.1:9999/CalculatorService/Metadata");
            //        host.Description.Behaviors.Add(behavior);
            //    }
            //    host.Opened += delegate { Console.WriteLine("CalculaorService已经启动，按任意键终止服务！"); };

            //    host.Open();
            //    Console.ReadKey();
            //}

            // 2.通过配置文件配置终结点
            using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
            {
                host.Opened += delegate { Console.WriteLine("CalculaorService已经启动，按任意键终止服务！"); };

                host.Open();
                Console.Read();
            }
        }

        static void HostCalculatorServiceViaCode()
        {
            Uri httpBaseAddress = new Uri("http://localhost:8002/GeneralCalculator");
            Uri tcpBaseAddress = new Uri("net.tcp://localhost:8003/GeneralCalculator");

            using (ServiceHost host = new ServiceHost(typeof(GeneralCalculatorService), httpBaseAddress, tcpBaseAddress))
            {
                BasicHttpBinding httpBinding = new BasicHttpBinding();
                NetTcpBinding tcpBinding = new NetTcpBinding();

                host.AddServiceEndpoint(typeof(IGeneralCalculator), httpBinding, string.Empty);
                host.AddServiceEndpoint(typeof(IGeneralCalculator), tcpBinding, string.Empty);

                ServiceMetadataBehavior behavior = host.Description.Behaviors.Find<ServiceMetadataBehavior>();
                if (behavior == null)
                {
                    behavior = new ServiceMetadataBehavior();
                    behavior.HttpGetEnabled = true;
                    host.Description.Behaviors.Add(behavior);
                }
                else
                {
                    behavior.HttpGetEnabled = true;
                }

                host.Opened += delegate { Console.WriteLine("CalculaorService已经启动，按任意键终止服务！"); };

                host.Open();
                Console.ReadKey();
            }
        }
    }
}
