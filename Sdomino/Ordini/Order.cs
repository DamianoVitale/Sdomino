using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdomino.Ordini
{
    internal class Order
    {
        public string Base { get; set; }
        public string Impasto { get; set; }
        public string[] Aggiunte { get; set; }
    }
}
