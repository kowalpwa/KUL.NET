using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStruktury
{
    // Struktura jest typem wartościowym
    struct Punkt
    {
        public int X { get; set; }
        public int Y { get; set; }

        // W strukturze nie możemy nadpisać domyślnego/bezparametrowego konstruktora

        //public Punkt()
        //{            
        //}

        public Punkt(int x, int y) : this()
        {
            X = x;
            Y = y;
        }


    }
}
