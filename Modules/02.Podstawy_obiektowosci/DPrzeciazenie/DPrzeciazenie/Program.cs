using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPrzeciazenie
{
    class Program
    {
        static void Main(string[] args)
        {
            // Przeciążenie i argumenty domyślne
            
            
            Przyklad obj = new Przyklad();


            obj.Wyswietl();

            obj.Wyswietl("2 argument typu string");

            obj.Wyswietl("3 Przyklad z 2 argumentami", 2);

            obj.Wyswietl(4, "4 Inny przykład z 2 TAKIMI SAMYMI argumentami, ale W INNEJ KOLEJNOŚCI");

            // Najczęstszą przyczyną stosowania przeciążenia jest chęć udostępnienia
            // kilku różnych sposobów wykonania TEGO SAMEGO zadania.


            obj.Domyslne(1);

            obj.Domyslne(1, trzeci: "Jawnie podany 3. parametr", drugi: 321.123);


            Console.ReadKey();
        }
    }
}
