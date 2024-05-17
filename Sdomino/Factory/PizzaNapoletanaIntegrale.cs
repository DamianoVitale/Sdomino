using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdomino.Factory
{
    internal class PizzaNapoletanaIntegrale : PizzaNapoletana
    {
        public override double GetPrice() => base.GetPrice() + 1;

    }
}
