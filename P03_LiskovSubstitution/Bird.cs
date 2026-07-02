namespace SolidPrinciples.P03_LiskovSubstitution;

/*
public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("El ave está volando");
    }
}

public class Sparrow : Bird
{
}

public class Penguin : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException("El pingüino no vuela");
    }
}
*/

public abstract class Bird
{
    public abstract void Move();
}