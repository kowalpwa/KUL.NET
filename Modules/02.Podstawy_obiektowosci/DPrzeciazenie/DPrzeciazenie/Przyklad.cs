using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPrzeciazenie
{
    // Przeciążaniem nazywamy sytuację, gdy w jakimś typie zostanie 
    // definiowana więcej niż jedna składowa o tej samej nazwie.

    class Przyklad
    {
        // Przy przeciążaniu metody/konstruktora ważne jest by we wcześniej zadeklarowanej składowej
        // O TEJ SAMEJ NAZWIE:
        //
        // -była różna ilość parametrów albo
        // -parametry były innego typu albo
        // -była różna kolejność wprowadzania parametrów, które były zadeklarowane wcześniej


        public void Wyswietl()
        {
            Console.WriteLine();
        }


        public void Wyswietl(string parametr)
        {
            Console.WriteLine(parametr);
        }


        public void Wyswietl(string parametr, int ileRazy)
        {
            for (int i = 0; i < ileRazy; i++)
            {
                Console.WriteLine(parametr);
            }
        }


        // W porównaniu do metody wyżej zmieniono tylko KOLEJNOŚĆ podawania argumentów
        public void Wyswietl(int ileRazy, string parametr)
        {
            for (int i = 0; i < ileRazy; i++)
            {
                Console.WriteLine(parametr);
            }
        }


        //--------------------------------------------------------------------------------\\

        // Parametry domyślne

        // Musimy podać CO NAJMNIEJ parametr pierwszy
        public void Domyslne(
            int pierwszy,
            double drugi = 2.2,
            string trzeci = "trzy",
            char czwarty = 's')
        {
            Console.WriteLine("Pierwszy = {0}, drugi = {1}, trzeci = {2}, czwarty = {3}",
                              pierwszy, drugi, trzeci, czwarty);
        }
    }
}
