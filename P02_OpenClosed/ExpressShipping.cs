namespace SolidPrinciples.P02_OpenClosed;

public class ExpressShipping : IShippingCostStrategy
{
    public decimal Calculate(decimal weight)
    {
        return 25m;
    }
}