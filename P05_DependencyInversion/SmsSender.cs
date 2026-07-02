namespace SolidPrinciples.P05_DependencyInversion;

public class SmsSender : IMessageSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Enviando SMS: {message}");
    }
}