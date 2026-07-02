namespace SolidPrinciples.P05_DependencyInversion;

public class EmailSender : IMessageSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Enviando correo: {message}");
    }
}