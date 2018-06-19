﻿using Services;
using System;
using System.ServiceModel;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
