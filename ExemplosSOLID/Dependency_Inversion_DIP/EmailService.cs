namespace ExemplosSOLID.Dependency_Inversion_DIP;

public class EmailService : INotificationService
{
    public void Send(string message, string recipient)
     => Console.WriteLine($"E-mail para {recipient}: {message}");
}