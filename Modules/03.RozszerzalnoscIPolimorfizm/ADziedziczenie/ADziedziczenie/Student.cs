using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ADziedziczenie
{
    // Klasa Student dziedziczy po klasie Czlowiek
    // Klasa student jest pochodną klasy bazowej Czlowiek
    class Student: Czlowiek
    {
        public string NazwaUczelni { get; set; }
        public int RokStudiow { get; set; }

        // Wykorzystanie właściwości "Imie" z modyfikatorem protected
        public void PrzedstawSie()
        {
            Console.WriteLine("Mam na imie {0}", Imie);
        }

        public void UczSie()
        {
            Console.WriteLine("Uczę się");
        }

        public void IdzNaImpreze()
        {
            Console.WriteLine("Lecę na melanż");
        }

    }
}
