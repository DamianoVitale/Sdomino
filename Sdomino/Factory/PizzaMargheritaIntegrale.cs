using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdomino.Factory
{
    internal class PizzaMargheritaIntegrale : PizzaMargherita
    {
        public override double GetPrice() => base.GetPrice() + 1;

    }
}
