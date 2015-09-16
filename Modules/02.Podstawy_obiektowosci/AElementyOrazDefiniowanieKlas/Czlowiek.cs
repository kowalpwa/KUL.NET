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

        // Właściwości - reprezentowanie stanu obiektu.


        public string Imie { get; set; }

        // Nazwisko można ustawić tylko przy użyciu konstruktora.
        private readonly string _nazwisko;

        public string Nazwisko
        {
            get
            {
                return _nazwisko;
            }
        }

        public DateTime DataUrodzenia { get; set; }



        public Czlowiek()
        {
            // Konstruktor pozwala nam dokonać "konfiguracji" podczas tworzenia obiektów.
            // Tak wygląda domyślny konstruktor - tylko tworzy obiekt.
        }


        // Konstruktorów może być wiele
        public Czlowiek(string imie, string nazwisko)
        {
            Imie = imie;
            _nazwisko = nazwisko;
        }


        // Wywołanie innego konstruktora w konstruktorze przy użyciu this()
        public Czlowiek(string imie, string nazwisko, DateTime dataUrodzenia) : this(imie, nazwisko)
        {       
            DataUrodzenia = dataUrodzenia;
        }



        // metoda klasy Czlowiek
        public void Przedstaw()
        {
            // Tutaj użyte formatowanie string.format();
            Console.WriteLine("{0} {1} ur. {2: yyyy/MM/dd}", Imie, _nazwisko, DataUrodzenia);
        }
    }
}
