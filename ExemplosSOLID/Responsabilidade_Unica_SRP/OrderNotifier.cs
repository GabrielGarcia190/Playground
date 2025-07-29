namespace ExemplosSOLID.Responsabilidade_Unica_SRP;
// Classe responsável apenas por enviar notificações
public class OrderNotifier
{
    public void SendConfirmationEmail(Order order)
        => Console.WriteLine($"E-mail enviado para {order.CustomerEmail}");
}