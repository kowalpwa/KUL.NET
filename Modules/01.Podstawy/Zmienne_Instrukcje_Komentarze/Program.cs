using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmienne_Instrukcje_Komentarze
{
    class Program
    {
        // Miejsce startu programu.
        static void Main(string[] args)
        {
            // ZMIENNE LOKALNE - POJEMNIKI NA DANE.

            // Deklaracja zmiennej typu int.
            int calkowita;

            // Inicjalizacja zadeklarowanej zmiennej.
            calkowita = 12;

            // Deklaracja z inicjalizacją.
            double zmiennoprzecinkowa = 123.3;

            // Niejawne określenie typu danych.
            var dowolny = "Każdy typ, ale trzeba uważać!";

            var zFloat = 123.12F;

            var zDecimal = 321.12345M;


            // INSTRUKCJE - WYKORZYSTYWANIE DANYCH.

            // Instrukcja deklaracji i inicjalizacji (przypisania).
            bool takCzyNie = false;


            // Instrukcje wyrażeń - Sekwencja operatorów i operandów.

            int wynik = 2 + 2*(2 - 4) + 8;

            // 2 + 2 to Samo wyrażenie, ale int wynik2 = 2 + 2; to instrukcja wyrażenia.

            Console.WriteLine("Hello World");

            bool czyRowne = 2 == 2;

            /* Operatory mają swoje priorytety
             
             * Komentarz wielowierszowy
             
             * 
             * Dalej ten sam komentarz
             */


            Console.ReadKey();
        }
    }
}
