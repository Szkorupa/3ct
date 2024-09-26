using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _19._09._2024.BJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] zmienna = new int [10];

            for (int i = 0; i <= 10; i++)
            {
                zmienna[i] = i;
                Console.WriteLine(zmienna[i].ToString());
                Debug.WriteLine("Informacje z działania programu");

            }
            Console.WriteLine("Podaj imię");
            string imie = Console.ReadLine();

            Console.ReadKey();
        }
    }
}
