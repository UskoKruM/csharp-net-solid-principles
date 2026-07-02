namespace SolidPrinciples.P03_LiskovSubstitution;

public class Penguin : Bird
{
    public override void Move()
    {
        Console.WriteLine("El pingüino camina y nada");
    }
}