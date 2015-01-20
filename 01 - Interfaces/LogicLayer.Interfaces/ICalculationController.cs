using System.Collections.Generic;
using LogicLayer.Interfaces.Entities;

namespace LogicLayer.Interfaces
{
    public interface ICalculationController
    {
        IEnumerable<ICostComponent> CalculateCost(ISite site);
    }
}
