using ExemploCSharp.Entities;
using ExemploCSharp.Interfaces;
using ExemploCSharp.Ioc;
using ExemploCSharp.Services;

namespace ExemploCSharp.Views;

public class AdicionarLivroView : IEscolhaUsuario
{
    public void ProcessarEscolha()
    {
        var livro = ObterInformacoesLivro();

        var livroService = DependencyInjection.GetService<LivroService>();
        livroService.AdicionarLivro(livro);

    }

    private Livro ObterInformacoesLivro()
    {
        Console.WriteLine("Título:");
        var titulo = Utils.Console.ReadLine();
        Console.WriteLine("Autor:");
        var autor = Utils.Console.ReadLine();
        Console.WriteLine("ISBN:");
        var isbn = Utils.Console.ReadLine();

        return new Livro(titulo, autor);
    }
}