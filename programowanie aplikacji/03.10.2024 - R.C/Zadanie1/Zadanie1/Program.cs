using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Podaj ciag znakow");

                string ciag = Console.ReadLine();

                if (ciag.Length <= 12)
                {
                    Console.WriteLine("Za maly");
                } else
                {   
                    Console.WriteLine("Pomyślnie wpisano");
                    Thread.Sleep(500);
                    return;
                }
                Console.ReadKey();
            }

        }
    }
}
