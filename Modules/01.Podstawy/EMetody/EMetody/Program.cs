using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMetody
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metody - na razie tylko statyczne

            Pokaz1();// Wywołanie metody

            Pokaz2("Przykładowy argument"); // Wywołanie metody z argumentem

            Console.WriteLine("Masz na imie {0}", PobierzImie()); // Wywołanie metody w środku innej

            DodajWiele(1, 2, 3, 4, 5, 6, 7.5, 9.13);


            Console.ReadKey();
        }


        static void Pokaz1() // Nie zwracając wartości używamy typu void
        {
            Console.WriteLine("\nWywołano metodę statyczną Pokaz1()");
        }


        static void Pokaz2(string parametr) // Metoda przyjmująca 1 parametr
        {
            Console.WriteLine("\nWywołano metodę Pokaz2() z argumentem {0}", parametr);
        }


        static int Dodawanie(int x1, int x2) // Metoda zwracająca wartość typu int
        {
            Console.WriteLine("\n");// Przejście do nowej linii - dla estetyki

            return x1 + x2;
        }


        static string PobierzImie()
        {
            string imie;

            do
            {
                Console.Write("Podaj swoje imię: ");
                imie = Console.ReadLine();
            } while (string.IsNullOrEmpty(imie)); // Jako zadanie napisać warunek IsNullOrEmpty

            return imie;
        }


        static void DodajWiele(params double[] parametry)
        {
            double wynik = 0;

            foreach (var wartosc in parametry)
            {
                wynik += wartosc;
            }

            Console.WriteLine("Wynik dodawania podanych liczb = {0}", wynik);

            // return parametry.Aggregate<int, double>(0, (current, wartosc) => current + wartosc);
        }
    }
}
