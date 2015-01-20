using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer.Calculators;
using LogicLayer.Interfaces.Entities;

namespace LogicLayer.Factories
{
    internal class CalculatorFactory
    {
        public IEnumerable<ICalculator> Create(ISite site)
        {
            var calcs = new List<ICalculator>();

            //always add unit rate calc
            calcs.Add(new UnitRateCalculator());

            //only add standing charge for DM
            if (site.IsDailyMetered)
            {
                calcs.Add(new StandingChargeCalculator());
            }

            return calcs;
        }
    }
}
