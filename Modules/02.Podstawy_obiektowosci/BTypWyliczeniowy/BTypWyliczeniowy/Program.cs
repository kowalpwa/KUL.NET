using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTypWyliczeniowy
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto();

            // Przykład przypisania wartości do właściwości typu wyliczeniowego
            auto1.MarkaAuta = Marka.Ferrari; 
            Console.WriteLine("\nWartość marki {0} w typie wyliczeniowym wynosi {1}",
                              auto1.MarkaAuta, (int)auto1.MarkaAuta);


            auto1.MarkaAuta = Marka.Mercedes;
            Console.WriteLine("\nWartość marki {0} w typie wyliczeniowym wynosi {1}",
                              auto1.MarkaAuta, (int)auto1.MarkaAuta);

            Console.ReadKey();
        }
    }
}
