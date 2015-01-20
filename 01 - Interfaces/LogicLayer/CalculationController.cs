using System;
using System.Collections.Generic;
using System.Linq;
using LogicLayer.Entities;
using LogicLayer.Factories;
using LogicLayer.Interfaces;
using LogicLayer.Interfaces.Entities;

namespace LogicLayer
{
    public class CalculationController : ICalculationController
    {
        /// <summary>
        /// Basic implementation to return some data items
        /// </summary>
        /// <param name="site"></param>
        /// <returns></returns>
        public IEnumerable<ICostComponent> BasicExample(ISite site)
        {
            var random = new Random();
            return new List<ICostComponent>
            {
                new CostComponent() {Cost = random.Next(1000), Description = "Random cost 1"},
                new CostComponent() {Cost = random.Next(1000), Description = "Random cost 2"},
            };
        }

        /// <summary>
        /// Refactored example that uses the factory pattern to create object and futher seperation of concerns to individual classes that perform each calculation
        /// </summary>
        /// <param name="site"></param>
        /// <returns></returns>
        public IEnumerable<ICostComponent> CalculateCost(ISite site)
        {
            var calculatorFactory = new CalculatorFactory();
            var calculators = calculatorFactory.Create(site);

            return (from c in calculators
                select c.Calculate(site));
        }
    }
}
