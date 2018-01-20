using ServiceTest.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client srv = new ServiceReference1.Service1Client();

            srv.AddAddress(new AddressWCF() { Comment = "Pista" });

            var address = srv.GetAddress(1);

            Console.WriteLine(address.Comment);

            Console.ReadKey();
        }
    }
}
