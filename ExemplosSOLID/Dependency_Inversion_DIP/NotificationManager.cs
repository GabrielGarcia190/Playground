namespace ExemplosSOLID.Dependency_Inversion_DIP;

public class NotificationManager
{
    private readonly INotificationService _service;

    public NotificationManager(INotificationService service)
     => _service = service;

    public void NotifyUser(string user, string message)
     => _service.Send(message, user);
}