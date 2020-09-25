using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wcfemplib;
using System.ServiceModel;
namespace WcfConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost svcHost = new ServiceHost(typeof(wcfemplib.Empservice));
            svcHost.Open();
            Console.WriteLine("service started..");
            Console.ReadLine();
            Console.WriteLine("service stopped");
        }
    }
}
