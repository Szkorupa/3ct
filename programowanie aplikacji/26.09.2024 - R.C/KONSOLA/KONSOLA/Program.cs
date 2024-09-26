using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KONSOLA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Wybierz zakres od ilu");
                int Zakres1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Wybierz zakres do ilu");
                int Zakres2 = Convert.ToInt32(Console.ReadLine());

                // [Zabezpieczenie] ++

                if (Zakres1 > Zakres2)
                {
                    Console.WriteLine("Błąd, nie można dać zakresu mniejszego od pierwszej liczby!!!");
                    break;
                }


                Random random = new Random();
                int losowa = random.Next(Zakres1, Zakres2);

                while (true)
                {
                    Console.WriteLine("Podaj liczbe w tym zakresie: ");

                    int PodanaLiczba = Convert.ToInt32(Console.ReadLine());

                    // Sprawdzam czy ktoś nie podał numeru za małego [ Zabezpieczenie ] 

                    if (PodanaLiczba < Zakres1)
                    {
                        Console.WriteLine("Błąd, podałeś numer za maly na ten zakres");

                        Console.WriteLine("Aby powtórzyc gre wpisz [ 2 ]");
                        string Blad1 = Console.ReadLine();
                        if (Blad1 == "1")
                        {
                            return;
                        }
                        else if (Blad1 == "2")
                        {
                            break;
                        }
                    }

                    if (PodanaLiczba > Zakres2)
                    {
                        Console.WriteLine("Błąd, podałeś numer za duży dla tego zakresu");

                        Console.WriteLine("Aby powtórzyc gre wpisz [ 2 ]");
                        string Blad2 = Console.ReadLine();
                        if (Blad2 == "1")
                        {
                            return;
                        }
                        else if (Blad2 == "2")
                        {
                            break;
                        }
                    }

                    // Powrót kodu

                    if (PodanaLiczba == losowa)
                    {
                        Console.WriteLine("Brawo zgadles");
                        Console.WriteLine("Aby wyjsc wpsiz [ 1 ] | Aby potworzyc gre wpisz [ 2 ]");
                        string wybor = Console.ReadLine();
                        if (wybor == "1")
                        {
                            return;
                        }
                        else if (wybor == "2")
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (PodanaLiczba > losowa)
                        {
                            Console.WriteLine("za duzo");
                        }
                        else if (PodanaLiczba < losowa)
                        {
                            Console.WriteLine("za malo");
                        }
                    }

                }
            }
               
            Console.ReadKey();
        }
    }
}
