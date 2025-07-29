namespace ExemplosSOLID.Dependency_Inversion_DIP;

public interface INotificationService
{
    void Send(string message, string recipient);
}
