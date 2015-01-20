using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer.Interfaces.Entities;

namespace LogicLayer.Calculators
{
    class StandingChargeCalculator : Calculator
    {
        public override ICostComponent Calculate(ISite site)
        {
            return CostComponentFactory.Create("Standing Charge", RandomGenerator.Next(100));
        }
    }
}
