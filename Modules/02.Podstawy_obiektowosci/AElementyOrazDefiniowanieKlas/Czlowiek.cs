using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AElementyOrazDefiniowanieKlas
{
    public class Czlowiek
    {
        // namespace -> class -> składowe klasy 

        // Właściwości - reprezentowanie stanu obiektu

        public string Imie { get; set; }
        private string Nazwisko { get; set; }
        public DateTime DataUrodzenia { get; set; }


        public Czlowiek()
        {
            // Konstruktor pozwala nam dokonać "konfiguracji" podczas tworzenia obiektów
            // Tak wygląda domyślny konstruktor - tylko tworzy obiekt
        }


        // Konstruktor klasy Czlowiek
        public Czlowiek(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        // Konstruktorów może być wiele
        public Czlowiek(string imie, string nazwisko, DateTime dataUrodzenia)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            DataUrodzenia = dataUrodzenia;
        }


        public void Przedstaw()// metoda klasy Czlowiek
        {
            Console.WriteLine("{0} {1} ur. {2: yyyy/MM/dd}", Imie, Nazwisko, DataUrodzenia);
        }
    }
}
