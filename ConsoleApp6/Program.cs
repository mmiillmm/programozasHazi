using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace szamok
{
    class Program
    {

        static List<int> szamok = new List<int>();

        static void Main(string[] args)
        {
            Beolvasas();

            Osszegzes(); // >a számok összege a listában

            Megszamolas(); // >100 <= szám és >= 550

            Kivalasztas(); // >3437 hányadik indexen van

            Kereses(); // >van-e benne 333 és ha van hol

            Maximum(); // >legnagyobb szám

            Minimum(); // >legkisebb szám

            Console.ReadKey();
        }

        private static void Kereses()
        {
            int ker = 0;

            for (int i = 0; i < szamok.Count; i++)
            {
                if (szamok[ker] != 333)
                {
                    ker++;
                }
            }

            Console.WriteLine($"Van 333 a listában. Indexe: {ker}.");
        }

        private static void Maximum()
        {
            int max = 0;

            for (int i = 1; i < szamok.Count; i++)
            {
                if (szamok[i] > max)
                {
                    max = szamok[i];
                }
            }

            Console.WriteLine($"Legnagyobb szám: {max}");
        }

        private static void Minimum()
        {
            int min = 0;

            for (int i = 1; i < szamok.Count; i++)
            {
                if (szamok[i] < min)
                {
                    min = szamok[i];
                }
            }

            Console.WriteLine($"Legkisebb szám: {min}");
        }



        private static void Kivalasztas()
        {
            int index = 0;

            for (int i = 0; i < szamok.Count; i++)
            {
                if (szamok[index] != 3437)
                {
                    index++;
                }
            }

            Console.WriteLine($"A 3437 ezen az indexen található: {index}");
        }

        private static void Megszamolas()
        {
            int szam = 0;

            for (int i = 0; i < szamok.Count; i++)
            {
                if (szamok[i] >= 100 && szamok[i] <= 550)
                {
                    szam++;
                }
            }

            Console.WriteLine($"Az összes kritériumnak megfelelő szám: {szam} db.");
        }

        private static void Osszegzes()
        {
            int sum = 0;

            for (int i = 0; i < szamok.Count; i++)
            {
                sum = sum + szamok[i];
            }

            Console.WriteLine($"A számok összege {sum}.");
        }

        private static void Beolvasas()
        {
            StreamReader beolv = new StreamReader("szamok.txt");

            while (!beolv.EndOfStream)
            {
                szamok.Add(Convert.ToInt32(beolv.ReadLine()));
            }

            beolv.Close();
        }
    }
}