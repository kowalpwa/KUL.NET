using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace WbudowaneTypyDanych_Operatory_SterowaniePrzeplywem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wbudowane typy danych - Patrz TabelaCS.jpg
            
            sbyte x = 127, y;
            y = x++;
            //checked {y = ++x;}
            Console.WriteLine("Wartość x wynosi: {0} \t wartość x+1 wynosi {1}", x, y);


            // Niejawna konwersja
            int a = 2;
            double b;

            b = a;
            Console.WriteLine("Wartość b wynosi {0}", b);

            // Jawna konwersja - rzutowanie
            int d;
            double c = 12.6;

            d = (int) c;
            Console.WriteLine("Wartość d wynosi {0}", d); // Część dziesiętna jest obcinana!


            BigInteger bI = 123; // Dowolnie wielka liczba całkowita

            bool wartoscLogiczna = true; //Prawda lub fałsz

            char znak = 'x'; //Dowolny znak

            string ciag = "Każdy osobny znak jest typu char";

            object magia = "W typie object możemy umieścić WSZYSTKO";
            Console.WriteLine("Typ object jako string: " + magia);
            magia = 12M;

            // O tablicach słów kilka

            int[] tablicaLiczb = new[] { 1, 2, 3, 4, 5, 6, 7 };
            


            // Operatory - Patrz Operatory.png

            int inkrementacja = 0;
            inkrementacja++;

            int dekrementacja = 0;
            dekrementacja--;

            int x1 = 3, x2 = 2;
            int wynikInt = x1/x2;
            Console.WriteLine("3 / 2 = {0}", wynikInt);

            float y1 = 3, y2 = 2;
            float wynikFloat = y1/y2;
            Console.WriteLine("3 / 2 = {0}", wynikFloat);

            Console.WriteLine("5 % 3 = {0}",5 % 3);

            string imie = "Rychu";
            string nazwisko = " Pompka";
            string jakSieNazywasz = imie + nazwisko; // Konkatenacja
            Console.WriteLine(jakSieNazywasz);

            // Operatory relacji
            bool czyWieksza = !(4 >= 5);
            Console.WriteLine("Wartość wyrażenia !(4 >= 5) = {0}", czyWieksza);

            int wieksza = (4 > 3) ? 4 : 3;
            Console.WriteLine("Wartość zmiennej wieksza = {0}", wieksza);

            

            var j = Regex.IsMatch("asd@ss.pl", @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            var czyKobieta = Regex.IsMatch("ad", @"^.*a$");


            Console.ReadKey();
        }
    }
}
