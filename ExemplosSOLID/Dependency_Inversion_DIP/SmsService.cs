namespace ExemplosSOLID.Dependency_Inversion_DIP;

public class SmsService : INotificationService
{
    public void Send(string message, string recipient)
     => Console.WriteLine($"SMS para {recipient}: {message}");
}