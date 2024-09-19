using System;

namespace zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] zmienna = new int[10];

            for (int i = 0; i <= 10; i++)
            {
                zmienna[i] = i;
                Console.WriteLine(zmienna[i].ToString());
                //Console.WriteLine("Informacja z działania programu");
                System.Diagnostics.Debug.WriteLine("Informacja z działania programu"); 
            }

            Console.WriteLine("Podaj Imie:");
            string imie=Console.ReadLine();
            Console.ReadKey();
        }
    }
}
