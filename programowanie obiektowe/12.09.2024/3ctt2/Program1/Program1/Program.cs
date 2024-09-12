using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj 3 CT");
            Console.WriteLine("Witaj 3 CT");

            Console.Write("Witaj 3CT" + Convert.ToChar(13) + Convert.ToChar(10));

            while (true)
            {
                Console.Write(DateTime.Now.ToString() + Convert.ToChar(13));
            }

            Console.ReadKey();
        }
    }
}
