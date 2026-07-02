namespace SolidPrinciples.P05_DependencyInversion;

public class WhatsAppSender : IMessageSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Enviando WhatsApp: {message}");
    }
}