using ExemploCSharp.Context;
using ExemploCSharp.Interfaces;
using ExemploCSharp.Repositories;
using ExemploCSharp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ExemploCSharp.Ioc;
public static class DependencyInjection
{
    private static ServiceProvider? _serviceProvider;

    public static void ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddDbContext<ExemploDBContext>(options =>
         {
             options.UseSqlite("Data Source=dev.db")
                         .LogTo(Console.WriteLine, LogLevel.Information);
         });

        services.AddScoped<ILivroRepository, LivroRepository>();

        services.AddScoped<LivroService>();

        _serviceProvider = services.BuildServiceProvider();
    }

    public static T GetService<T>()
    {
        if (_serviceProvider == null)
            throw new InvalidOperationException("Service provider não configurado.");

        return _serviceProvider.GetService<T>() ?? throw new InvalidOperationException($"Service do tipo {typeof(T)} não foi registrado.");
    }
}
