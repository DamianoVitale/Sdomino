using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdomino.Ordini
{
    internal class Scontrino
    {
        public static int ordeerid = 0;
        public int Id { get; set; }
        public double Totale { get; set; }
        public Scontrino(double price)
        {
            ordeerid++;
            Id = ordeerid;
            Totale = price;
        }

    }
}
