﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdomino.Factory
{
    internal class PizzaBiancaIntegrale : PizzaBianca
    {
        public override double GetPrice() => base.GetPrice() + 1;

    }
}
