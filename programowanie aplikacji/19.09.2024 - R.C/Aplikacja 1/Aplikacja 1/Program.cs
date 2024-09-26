using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;   
using System.Threading.Tasks;
using System.Diagnostics;

namespace Aplikacja_1
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            int[] zmienna = new int[10];


            for (int i = 0; i < 10 ; i++)
            
            {
                zmienna[i] = i;
                Console.WriteLine(zmienna[i].ToString());

                Debug.WriteLine("Jestem w petli");
            }

            Console.ReadKey();
        }
    }
}
