using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPetle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pętla while - Dopóki warunek w nawiasach jest prawdziwy..

            int ile = 0;

            while (ile != 5)
            {
                Console.Write("Podaj 5: ");
                int.TryParse(Console.ReadLine(), out ile);
            }



            // Pętla do while - wykona się przynajmniej raz

            int ile2;

            do
            {
                Console.Write("Podaj 6: ");
                int.TryParse(Console.ReadLine(), out ile2);

                if (ile2 > 6)// Przerwanie wykonywania pętli
                    break;

            } while (ile2 != 6);



            // Pętla for - iteruje określoną ilość razy

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n\n");

            for (int i = 0; i < 5; i++)
            {
                if(i % 2 != 0) // Pominięcie iteracji pętli + warunek nieparzystości
                    continue;

                Console.WriteLine(i);
            }

            Console.WriteLine("\n\n");

            // Pętla foreach - przetworzy każdy element w danej kolekcji

            var kolekcja = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};

            foreach (int zmiennaTypuKolekcji in kolekcja)
            {
                Console.WriteLine(zmiennaTypuKolekcji);
            }


            Console.ReadKey();
        }
    }
}
