namespace LogicLayer.Interfaces.Entities
{
    public interface ISite
    {
        int CustomerId { get; }
        string MeterPointRef { get; }
        bool IsDailyMetered { get; }
    }
}
