using ExemploCSharp.Context;
using ExemploCSharp.Factories;
using ExemploCSharp.Ioc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ExemploCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            DependencyInjection.ConfigureServices();

            InitializeDatabase();

            GerarMenu();
        }
        private static void InitializeDatabase()
        {
            using (var scope = DependencyInjection.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ExemploDBContext>();
                context.Database.Migrate();
            }
        }
        private static void GerarMenu()
        {
            Console.WriteLine("1 - Adicionar Livro");
            Console.WriteLine("2 - Listar Livros");
            Console.WriteLine("3 - Registrar Usuário");
            Console.WriteLine("4 - Emprestar Livro");
            Console.WriteLine("5 - Devolver Livro");
            Console.WriteLine("6 - Sair");

            var opcaoEscolhida = Console.ReadLine();

            try
            {
                var escolhaUsuarioFactory = EscolhaUsuarioFactory.RetornarEscolhaUsuario(opcaoEscolhida);

                escolhaUsuarioFactory.ProcessarEscolha();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}