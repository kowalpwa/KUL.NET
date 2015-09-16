using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AElementyOrazDefiniowanieKlas
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek obj1 = new Czlowiek();// Stworzenie obiektu/instancji klasy

            obj1.Imie = "Jan";
            // obj1.Nazwisko = "Kowalski";
            obj1.DataUrodzenia = new DateTime(1994, 3, 27);

            obj1.Przedstaw();


            Czlowiek obj2 = new Czlowiek( "Adam", "Kaźmierski", new DateTime(1994, 3, 27));
            obj2.Przedstaw();


            // Inicjalozowanie publicznych pól i właściwości obiektu przy tworzeniu 
            Czlowiek obj3 = new Czlowiek()
            {
                DataUrodzenia = new DateTime(1990, 12, 23),
                Imie = "Andrzej"
            };

            Console.WriteLine("\n\n"+obj2.Nazwisko);
            

            Console.ReadKey();
        }
    }
}
