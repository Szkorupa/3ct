using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography.X509Certificates;

namespace Aplikacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Ini = new ConfigFile(@"./config.ini");
            string parameter_value;

            parameter_value = Ini.Read("ipaddress", "printer");
            Console.WriteLine("ip address = " + parameter_value);

            parameter_value = Ini.Read("port", "printer");
            Console.WriteLine("port = " + parameter_value);

            string printer_name;
            parameter_value = Ini.Read("printer_name", "Printer");
            if (string.IsNullOrEmpty(parameter_value))
            {
                printer_name = "default_name";
                Ini.Write("printer_name", printer_name, "Printer");
            }
            else if (!string.IsNullOrEmpty(parameter_value))
            {
                printer_name = parameter_value;
            }

            


            var i = 1;
            while (true)
            {
                Console.WriteLine("Lezy " + i + " skibidi");
                i++;
                Thread.Sleep(1000);

                if (i == 34)
                {
                    Console.WriteLine("Za 34");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
