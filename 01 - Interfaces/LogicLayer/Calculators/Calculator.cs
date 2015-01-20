using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer.Calculators;
using LogicLayer.Factories;
using LogicLayer.Interfaces.Entities;

namespace LogicLayer.Calculators
{
    internal abstract class Calculator : ICalculator
    {
        protected CostComponentFactory CostComponentFactory = new CostComponentFactory();
        protected Random RandomGenerator = new Random();

        public abstract ICostComponent Calculate(ISite site);
    }
}
