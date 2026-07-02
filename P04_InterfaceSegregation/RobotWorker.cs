namespace SolidPrinciples.P04_InterfaceSegregation;

public class RobotWorker : IWorkable
{
    public void Work()
    {
        Console.WriteLine("El robot trabaja");
    }
}