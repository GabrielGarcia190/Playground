namespace ExemplosSOLID.Responsabilidade_Unica_SRP;
// Classe responsável apenas por salvar no banco de dados
public class OrderRepository
{
    public void SaveToDatabase(Order order)
        => Console.WriteLine($"Pedido {order.Id} salvo no DB");
}