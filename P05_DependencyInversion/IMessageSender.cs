namespace SolidPrinciples.P05_DependencyInversion;

public interface IMessageSender
{
    void Send(string message);
}