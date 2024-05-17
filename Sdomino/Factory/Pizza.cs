using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdomino.Factory
{
    public abstract class Pizza
    {
        public double Price { get; set; }
        public abstract double GetPrice();
    }
}
