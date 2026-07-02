namespace SolidPrinciples.P05_DependencyInversion;

public class EmailSender_Legacy
{
    public void Send(string message)
    {
        Console.WriteLine($"Enviando correo: {message}");
    }
}

public class NotificationService_Legacy
{
    private readonly EmailSender_Legacy _emailSender = new EmailSender_Legacy();

    public void Notify(string message)
    {
        _emailSender.Send(message);
    }
}