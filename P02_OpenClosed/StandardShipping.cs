namespace SolidPrinciples.P02_OpenClosed;

public class StandardShipping : IShippingCostStrategy
{
    public decimal Calculate(decimal weight)
    {
        return 10m;
    }
}