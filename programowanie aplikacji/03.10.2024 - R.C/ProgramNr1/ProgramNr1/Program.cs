using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramNr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ciag = "ABCDEFGHIJKLMNPRSTUVYZX0123456789";
            string[] tablica_ciagow = { "napis1", "napis2", "napis3" };

            Console.WriteLine(tablica_ciagow[0]); // index

            int dlugosc = ciag.Length; // Sprawdzanie dlugosci ciagu znakow

            // Dodawanie ciągów

            string c1 = "012345";
            string c2 = "6789";
            string c3 = c1 + c2;

            string c5 = c3 + c1[2];


            string c4 = String.Join("", tablica_ciagow); // Odzielanie tablicy za pomoca czego kolwiek


            // Wycinanie ze string
            string partof;
            partof = ciag.Substring(2, 5); // 2 to od ktorego znaku, a 5 to jak duzo chcemy wyciac

            // Czy dany ciąg zawiera
            bool czyzawiera = c1.Contains("2");

            // Na której pozycji zawiera
            int pozycja = c1.IndexOf("6");

            // Zamiania liter na duze
            string odczyt = "tak";
            string parametr = odczyt.ToUpper();

            // Podział stringa
            string do_podzialu = "10.5, 13.4, 16.5, 18.7, 21.2, 26.5, 14.2";
            string[] temperatury = do_podzialu.Split(' ');

            // Podmiana znaków
            string zawiera_spacje = "RUM C A J S";
            string bez_spacji = zawiera_spacje.Replace(" ", "" /* String.Empty - puste*/); // 1 wartość, to co zamienia, a 2 wartość na co zamienia.

            // Usunięcie fragmentu
            string do_obrobki = "BrodaRumcajsa";
            // string po_obrobce = do_obrobki.Remove(1, 5); // 1 wartosc od ktorego znaku, 2 wartosc ile znakow

            string po_obrobce = do_obrobki.Remove(do_obrobki.IndexOf("Broda"), 6);

            Console.ReadKey();
        }
    }
}
