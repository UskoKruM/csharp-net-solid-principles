namespace SolidPrinciples.P05_DependencyInversion;

public class TelegramSender : IMessageSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Enviando mensaje por Telegram: {message}");
    }
}