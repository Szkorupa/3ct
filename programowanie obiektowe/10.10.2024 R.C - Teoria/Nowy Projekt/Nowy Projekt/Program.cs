using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nowy_Projekt
{
    internal class Program
    {
        // jak nie przypiszemy wartosci to nam liczy od zera
        enum typ_skrzyni 
        {
            manualna=1,
            automatyczna=2
        }

        enum dni_tygodnia
        {
            poniedzialek=1,
            wtorek=2,
            sroda=3,
            czwartek=4,
            piatek=5,
            sobota=6,
            niedziela=7
        }

        // Komentarz: ENUM nie przyjmie wartości string. tylko int

        static void Main(string[] args)
        {
            int skrzynia_biegow;
            skrzynia_biegow = 1;

            // 1 - skrzynia manualna
            // 2 - skrzynia automatyczna

            if (skrzynia_biegow == 1)
            {
                Console.WriteLine("Skrzynia manuala");
            } else if (skrzynia_biegow == 2)
            {
                Console.WriteLine("Skrzynia automatyczna");
            }

            typ_skrzyni typ_Skrzyni = new typ_skrzyni();
            // lub
            // typ_skrzyni typ_Skrzyni = typ_skrzyni.manualna 

            if (skrzynia_biegow == (int)typ_skrzyni.manualna)
            {
                Console.WriteLine("Skrzynia manuala");
            }
            else if (skrzynia_biegow == (int)typ_skrzyni.automatyczna)
            {
                Console.WriteLine("Skrzynia automatyczna");
            }



            // Dni tygodnia

            int liczba_dni;
            liczba_dni = 5 + (int)dni_tygodnia.czwartek;


            // Konwersja niejawna, odbywa się na poziomie kompilatora
            int a = 10;
            int b;

            b = a;

            // Konwersja jawna

            b = (long)a;
            b = Convert.ToInt64(b);




        }
    }
}
