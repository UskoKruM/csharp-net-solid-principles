namespace SolidPrinciples.P03_LiskovSubstitution;

public class Sparrow : Bird, IFlyingBird
{
    public override void Move()
    {
        Console.WriteLine("El gorrión se mueve caminando o saltando");
    }

    public void Fly()
    {
        Console.WriteLine("El gorrión vuela");
    }
}