namespace SolidPrinciples.P02_OpenClosed;

public interface IShippingCostStrategy
{
    decimal Calculate(decimal weight);
}