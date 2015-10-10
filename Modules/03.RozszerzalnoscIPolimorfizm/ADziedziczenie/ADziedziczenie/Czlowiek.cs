using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ADziedziczenie
{
    // W tym przykładzie Czlowiek jest klasą bazową
    class Czlowiek
    {
        protected string Imie { get; set; }// Do tej składowej dostaną się tylko klasy dziedziczące
        public DateTime DataUrodzenia { get; set; }
        public Sex Plec { get; set; }
        private int _zmienna; // Ta składowa nie będzie dziedziczona!

        public enum Sex
        {
            Kobieta = 0,
            Mezczyzna
        };

        public void Jedz()
        {
            Console.WriteLine("Spożywam posiłek");
        }

        public void Spij()
        {
            Console.WriteLine("Idę spać");
        }

    }
}
