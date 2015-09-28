using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESkladoweStatyczne
{
    // Składowe statyczne w klasie są "wspólne" dla wszystkich instancji klas

    class ZwyklaKlasa
    {
        public string Zdanie { get; set; }
        public static string StaticZdanie { get; set; }

        // Metody statyczne mogą odwoływać się TYLKO do składowych statycznych.
        //
        // Konstruktor statyczny wykonywany jest TYLKO RAZ.
        static ZwyklaKlasa()
        {
            StaticZdanie = "Zdanie przypisane w konstruktorze statycznym";
            Console.WriteLine("ZwyklaKlasa -> Konstruktor Statyczny");
        }

        public ZwyklaKlasa(string x)
        {
            Zdanie = x;
        }


        public static void StaticPokaz()
        {
            Console.WriteLine("ZwyklaKlasa -> StaticPokaz()");
        }
    }
}
