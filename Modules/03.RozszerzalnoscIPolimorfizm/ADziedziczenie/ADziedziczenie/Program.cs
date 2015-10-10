using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADziedziczenie
{
    class Program
    {
        // W dziedziczeniu klasa pochodna:
        // - posiada wszystkie nieprywatne składowe klasy bazowej
        // - 
        static void Main(string[] args)
        {
            Czlowiek czlowiek1 = new Czlowiek()
            {
                DataUrodzenia = new DateTime(1994, 3, 27),
                // Imie = "Adam",
                Plec = Czlowiek.Sex.Mezczyzna
            };

            Student student1 = new Student()
            {
                DataUrodzenia = new DateTime(1992, 2, 15),
                // Imie = "Grażyna",
                NazwaUczelni = "Wyższa szkoła mycia okien",
                RokStudiow = 2,
                Plec = Czlowiek.Sex.Kobieta
            };

            // Nie możemy się odwołać do właściwości "Imie", ponieważ
            // jest ono oznaczone jako "protected", a klasa Program
            // nie dziedziczy po klasie Czlowiek


            //-------------------------------POLIMORFIZM---------------------------------//

            Console.WriteLine("\n\n\nPOLIMORFIZM");

            // Traktowanie TYPU POCHODNEGO jako TYP BAZOWY jest przykładem polimorfizmu!

            // Możemy potraktować Studenta jako Człowieka, z tym, że będzie on miał dostęp
            // do składników klasy "Człowiek", mimo, że może też mieć zadeklarowane już wcześniej
            // składniki klasy "Student"

            Czlowiek czlowiek2 = student1;// Przypisanie referencji, nie wartości pól

            Console.WriteLine("\nJestem {0}", czlowiek2.Plec);


            // Nie można przypisać TYPU KLASY BAZOWEJ do TYPU KLASY POCHODNEJ!


            Console.ReadKey();
        }

    }
}
