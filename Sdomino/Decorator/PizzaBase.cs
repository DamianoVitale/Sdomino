using Sdomino.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdomino.Decorator
{
    internal class PizzaBase : Pizza
    {
        public override double GetPrice() => 0.00;
    }
}

   
