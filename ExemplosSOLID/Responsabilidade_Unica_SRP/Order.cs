namespace ExemplosSOLID.Responsabilidade_Unica_SRP;

public class Order
{
    public Order(int id, string customerEmail)
    {
        Id = id;
        CustomerEmail = customerEmail;
    }

    public int Id { get; private set; }
    public string CustomerEmail { get; private set; }
}