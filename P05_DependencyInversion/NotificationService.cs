namespace SolidPrinciples.P05_DependencyInversion;

public class NotificationService(IMessageSender messageSender)
{
    public void Notify(string message)
    {
        messageSender.Send(message);
    }
}