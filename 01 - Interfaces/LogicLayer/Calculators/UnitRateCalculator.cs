using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer.Interfaces.Entities;

namespace LogicLayer.Calculators
{
    class UnitRateCalculator : Calculator
    {
        public override ICostComponent Calculate(ISite site)
        {
            return CostComponentFactory.Create("Unit Rate", RandomGenerator.Next(10));
        }
    }
}
