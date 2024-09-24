using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Console.WriteLine("Witaj 3ct");
             Console.WriteLine("Witaj 3ct");
             Console.Write("Witaj 3ct\r\n"); 
             Console.Write("Witaj 3ct\r\n");
             Console.Write("Witaj 3" + Convert.ToChar(67) + Convert.ToChar(84) + Convert.ToChar(13) + Convert.ToChar(10));

             Console.Write("jhgfhjvbdeveh " + Convert.ToChar(0));
            */
            while (true)
            {
                Console.Write(DateTime.Now.ToString() + Convert.ToChar(13));
            }
            Console.ReadKey();
        }
    }
}
