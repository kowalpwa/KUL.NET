using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStruktury
{
    class Program
    {
        // Typ wartośiowy, a referencyjny.

        static void Main(string[] args)
        {
            Referencja r1 = new Referencja();
            Referencja r2 = new Referencja();

            r1.Liczba = 1;

            Console.WriteLine("Początkowa wartość właściwości obiektu r1 wynosi {0}, a r2 {1}",
                              r1.Liczba, r2.Liczba);

            // Przypisanie REFERENCJI obiektu r1 do obiektu r2.
            r2 = r1;
          
            // Teraz obiekt r2 przechowuje REFERENCJĘ do obiektu r1.
            // Każda zmiana na obiekcie r2 będzie widoczna na obiekcie r1.

            r2.Liczba = 2;

            Console.WriteLine("\nPo zmianie TYLKO NA OBIEKCIE r2 wartości właściwości obiektu" +
                              " r1 wynosi {0}, a r2 {1}", r1.Liczba, r2.Liczba);

            /*------------------------------------------------------------------------------------*/

            // Zwróć uwagę, że domyślnie przy tworzeniu obiektu struktury, jego składowe są wypełniane
            // wartośćiami dla nich domyślnymi.
            Punkt p1 = new Punkt();
            Punkt p2 = new Punkt(2, 2);

            Console.WriteLine("\n\nPoczątkowa wartość składowych struktury p1 wynosi {0}.{1}, a p2 {2}.{3}",
                              p1.X, p1.Y, p2.X, p2.Y);

            // Przypisanie WARTOŚCI struktury p1 do struktury p2.
            p2 = p1;

            Console.WriteLine("\nPo przypisaniu wartość składowych struktury p1 wynosi {0}.{1}, a p2 {2}.{3}",
                              p1.X, p1.Y, p2.X, p2.Y);

            p2.X = 22;
            p2.Y = 13;

            // Typy wartościowe NIE SĄ ze sobą powiązane.
            // Przez przypisanie do siebie typów wartościowych, następuje przypisanie WARTOŚCI ich,
            // składowych, a nie REFERENCJI do nich.

            Console.WriteLine("\n\nPo zmienie TYLKO NA STRUKTURZE p2: p1 wynosi {0}.{1}, a p2 {2}.{3}",
                              p1.X, p1.Y, p2.X, p2.Y);



            Console.ReadKey();
        }
    }
}
