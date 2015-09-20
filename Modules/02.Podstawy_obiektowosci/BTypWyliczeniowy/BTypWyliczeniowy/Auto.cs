using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTypWyliczeniowy
{
    // Typ wyliczeniowy - powiązane ze sobą stałe

    enum Marka
    {
        Ferrari = 2, // Domyślnie ma wartość 0
        Mercedes // Przyjmuje poprzednią wartość powiększoną o 1
    }


    class Auto
    {
        // Full property
        private Marka _markaAuta;

        public Marka MarkaAuta
        {
            get
            {
                return _markaAuta;
            }
            set
            {
                _markaAuta = value;
            }
        }
    }
}
