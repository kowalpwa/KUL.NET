using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESkladoweStatyczne
{
    // Klasa statyczna może posiadać TYLKO STATYCZNE SKŁADOWE.
    //
    // Nie można utworzyć obiektu klasy statycznej
    static class StatycznaKlasa
    {
        // Głównym zastosowaniem danych statycznych jest wymuszenie, by
        // w całym systemie istniał rzeczywiście tylko jeden egzemplarz pewnej danej.
        private static int _jakiesPole;

        public static string StaticProp { get; set; }


        // Konstruktor statyczny jest wykonywany TYLKO RAZ
        static StatycznaKlasa()
        {
            Console.WriteLine("StatycznaKlasa -> Konstruktor statyczny");
            _jakiesPole = 12;
            StaticProp = "Wartość przypisana w konstruktorze statycznym";
        }


        public static void Pokaz1()
        {
            Console.WriteLine("Statyczna Klasa -> Pokaz1()");
        }
    }
}
