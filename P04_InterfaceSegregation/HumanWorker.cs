namespace SolidPrinciples.P04_InterfaceSegregation;

public class HumanWorker : IWorkable, IEatable
{
    public void Work()
    {
        Console.WriteLine("La persona trabaja");
    }

    public void Eat()
    {
        Console.WriteLine("La persona come");
    }
}