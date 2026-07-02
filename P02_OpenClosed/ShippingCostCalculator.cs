namespace SolidPrinciples.P02_OpenClosed;

public class ShippingCostCalculator
{
    public decimal Calculate(string shippingType)
    {
        if (shippingType == "Standard")
            return 10m;

        if (shippingType == "Express")
            return 25m;

        if (shippingType == "International")
            return 80m;

        if (shippingType == "StorePickup")
            return 0m;

        throw new ArgumentException("Tipo de envío no válido");
    }
}