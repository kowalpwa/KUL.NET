using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESkladoweStatyczne
{
    class Program
    {
        // Do składowej statycznej odwołujemy się przez NazwaKlasy.Składowa,
        // a nie przez obiekt klasy.
        static void Main(string[] args)
        {
            // Konstruktor statyczny zostanie wywołany nie później, niż zostanie
            // utworzony obiekt danej klasy lub wywołana statyczna metoda tej klasy.

            StatycznaKlasa.Pokaz1();// Wywołanie statycznego elementu
            StatycznaKlasa.Pokaz1();

            Console.WriteLine("\n");

            ZwyklaKlasa obj = new ZwyklaKlasa("Argument podany w konstruktorze");

            ZwyklaKlasa.StaticPokaz();
            ZwyklaKlasa.StaticPokaz();


            obj.Zdanie = "Zdanie";


            Console.ReadKey();
        }
    }
}
