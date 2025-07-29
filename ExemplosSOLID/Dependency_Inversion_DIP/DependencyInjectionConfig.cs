using Microsoft.Extensions.DependencyInjection;

namespace ExemplosSOLID.Dependency_Inversion_DIP;

public static class DependencyInjection
{
    private static IServiceProvider? _serviceProvider;

    // Configura todos os serviços e constrói o provedor
    public static void ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddTransient<INotificationService, EmailService>();
        services.AddTransient<NotificationManager>();
        // Adicione outros serviços aqui...

        _serviceProvider = services.BuildServiceProvider();
    }

    // Método para resolver serviços (substitui o GetRequiredService direto)
    public static T GetService<T>() where T : notnull
    {
        if (_serviceProvider == null)
        {
            throw new InvalidOperationException("ConfigureServices deve ser chamado primeiro!");
        }
        return _serviceProvider.GetRequiredService<T>();
    }
}