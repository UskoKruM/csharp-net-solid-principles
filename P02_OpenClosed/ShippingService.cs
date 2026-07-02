namespace SolidPrinciples.P02_OpenClosed;

public class ShippingService
{
    public decimal CalculateCost(IShippingCostStrategy strategy,decimal weight)
    {
        return strategy.Calculate(weight);
    }
}