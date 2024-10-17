using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Ini = new ConfigFile(@"./config.ini");

            string wybor;
            string dane;
            string sekcja, parametr, wartosc;

            // deklara


            while (true)
            {
                Console.WriteLine("Wybierz opcje");
                Console.WriteLine("1 - Utwórz parametr, 2 - usuń paramter, 3 - odczytaj parametr");
                wybor = Console.ReadLine();

                if (wybor == "1")
                {
                    Console.WriteLine("Podaj dane zgodnie z strukturą: SEKCJA$PARAMETR%WARTOSC");
                    dane = Console.ReadLine();
                    sekcja = dane.Substring(0, dane.IndexOf("$"));
                    parametr = dane.Substring(dane.IndexOf("$") + 1, dane.IndexOf("%") - dane.IndexOf("$") - 1);
                    wartosc = dane.Substring(dane.IndexOf("%") + 1);
                    Ini.Write(parametr, wartosc, sekcja);

                }

                else if (wybor == "2")
                {


                    Console.WriteLine("Podaj dane do usuniecia zgodnie z strukturą: SEKCJA$PARAMETR%WARTOSC");
                    dane = Console.ReadLine();

                    sekcja = dane.Substring(0, dane.IndexOf("$"));
                    parametr = dane.Substring(dane.IndexOf("$") + 1, dane.IndexOf("%") - dane.IndexOf("$") - 1);
                    wartosc = dane.Substring(dane.IndexOf("%") + 1);

                    string wynik_odczytu = Ini.Read(parametr, sekcja);
                    Console.WriteLine("Usuwam:  " + wynik_odczytu);

                    Ini.DeleteKey(parametr, sekcja);
                }
                else if (wybor == "3")
                {

                    Console.WriteLine("Podaj dane do usuniecia zgodnie z strukturą: SEKCJA$PARAMETR%WARTOSC");
                    dane = Console.ReadLine();

                    sekcja = dane.Substring(0, dane.IndexOf("$"));
                    parametr = dane.Substring(dane.IndexOf("$") + 1, dane.IndexOf("%") - dane.IndexOf("$") - 1);
                    wartosc = dane.Substring(dane.IndexOf("%") + 1);

                    string wynik_odczytu = Ini.Read(parametr, sekcja);
                    Console.WriteLine("Odczyt: " + wynik_odczytu);
                } else
                {
                    Console.WriteLine("Błąd");
                    return;
                }

                // SEKCJA$PARAMETR%WARTOSC


            }
            Console.ReadKey();
        }
    }
}
