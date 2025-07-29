namespace ExemplosSOLID.Dependency_Inversion_DIP
{
    public static class ExemploDeUso
    {
        public static void Executar()
        {
            var notificationManager = DependencyInjection.GetService<NotificationManager>();
            notificationManager.NotifyUser("user@example.com", "Teste de mensagem");

        }
    }
}