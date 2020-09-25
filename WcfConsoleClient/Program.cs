using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfConsoleClient.ServiceReference1;

namespace WcfConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpserviceClient proxy = new EmpserviceClient();
            string result = proxy.GetData(100);
            Console.WriteLine(result);

        }
    }
}
