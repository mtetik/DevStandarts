using LogicLayer.Entities;
using LogicLayer.Interfaces.Entities;

namespace LogicLayer.Factories
{
    internal class CostComponentFactory
    {
        public ICostComponent Create(string description, decimal cost)
        {
            return new CostComponent()
            {
                Cost = cost,
                Description = description
            };
        }
    }
}
