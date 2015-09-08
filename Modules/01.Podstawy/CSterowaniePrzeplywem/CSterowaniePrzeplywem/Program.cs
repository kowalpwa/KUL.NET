using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSterowaniePrzeplywem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instrukcja wyboru if

            int wiek = 0;
            Console.Write("Podaj swój wiek: ");
            wiek = int.Parse(Console.ReadLine());// Pobranie danych z klawiatury + konwersja na int

            if (wiek > 18)// W środku nawiasów warunek logiczny
            {
                Console.WriteLine("Idziemy na integracyjny browar po spotkaniu!");
            }
            else if (wiek < 18)// W innym wypadku..
            {
                Console.WriteLine("Nie mów mamie, że byłeś z nami na piwie!");
            }
            else // W pozostałych przypadkach..
            {
                Console.WriteLine("Masz 18 lat (jak byś nie wiedział..)");
            }


            // Instrukcja wyboru switch

            int lataNauki;

            Console.WriteLine("Ile lat uczysz się programowania?");

            if(!int.TryParse(Console.ReadLine(), out lataNauki))
                Console.WriteLine("Coś poszło nie tak :(");

            switch (lataNauki)
            {
                case 0:
                    Console.WriteLine("Czas najwyższy zacząć :)");
                    break;
                case 1:
                    Console.WriteLine("Początki są najtrudniejsze..");
                    break;
                case 2:
                    Console.WriteLine("Zaczynasz coś rozumieć..");
                    break;
                case 3:
                    Console.WriteLine("Hajs się zaczyna zgadzać :D");
                    break;
                default: // default jest opcjonalny - jeśli go nie będzie to nie wywoła to błędu
                    Console.WriteLine("Im więcej wiesz tym więcej widzisz rzeczy do nauczenia.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
