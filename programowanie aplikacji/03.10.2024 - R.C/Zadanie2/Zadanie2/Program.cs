using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ciag;
            while (true)
            {
                Console.WriteLine("Podaj ciag znakow");
                ciag = Console.ReadLine();

                if (ciag.Length <= 12)
                {
                    Console.WriteLine("Za maly");
                }
                else
                {
                    Console.WriteLine("Pomyślnie wpisano");
                }
                Random random = new Random();
                string genHaslo = "";
                for (int i = 0; i < 15; i++)
                {
                    int losowyZnak = random.Next(0, ciag.Length);
                    genHaslo += ciag[losowyZnak];
                }

                Console.WriteLine(genHaslo);
                Thread.Sleep(2000);
                // Console.Clear();

                // Zadanie 3 pobieranie znakow
                Console.WriteLine("Zadanie 3");

                string pobieranie;
                pobieranie = genHaslo.Substring(2, 4);

                string noweHaslo = genHaslo + pobieranie;
                Console.WriteLine(noweHaslo);

                Thread.Sleep(2000);
                // Console.Clear();

                // Zadanie 4
                Console.WriteLine("Zadanie 4");

                string usuwanie = noweHaslo.Remove(0, 2);
                Console.WriteLine(usuwanie);

                Console.ReadKey();
            }
        }
    }
}
