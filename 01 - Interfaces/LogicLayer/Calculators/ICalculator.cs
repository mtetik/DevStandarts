using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer.Interfaces.Entities;

namespace LogicLayer.Calculators
{
    internal interface ICalculator
    {
        ICostComponent Calculate(ISite site);
    }
}
