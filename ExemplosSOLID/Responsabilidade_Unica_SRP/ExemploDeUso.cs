namespace ExemplosSOLID.Responsabilidade_Unica_SRP;

public static class ExemploDeUso
{
    public static void Executar()
    {
        // Uso:
        var order = new Order(id: 1, customerEmail: "cliente@email.com");
        var processor = new OrderProcessor();
        var repository = new OrderRepository();
        var notifier = new OrderNotifier();

        processor.ProcessOrder(order);
        repository.SaveToDatabase(order);
        notifier.SendConfirmationEmail(order);
    }
}