namespace SolidPrinciples.P02_OpenClosed;

public class InternationalShipping : IShippingCostStrategy
{
    public decimal Calculate(decimal weight)
    {
        if (weight <= 5)
            return 80m;

        return 120m;
    }
}