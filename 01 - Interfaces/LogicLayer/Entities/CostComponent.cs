using LogicLayer.Interfaces.Entities;

namespace LogicLayer.Entities
{
    internal class CostComponent : ICostComponent
    {
        public string Description { get; set; }
        public decimal Cost { get; set; }
    }
}
