namespace ExemplosSOLID.Responsabilidade_Unica_SRP;
// Classe responsável apenas por registrar o pedido
public class OrderProcessor
{
    public void ProcessOrder(Order order)
    => Console.WriteLine($"Pedido {order.Id} processado em {DateTime.Now}");
}