using ExemploCSharp.Interfaces;
using ExemploCSharp.Ioc;
using ExemploCSharp.Services;

namespace ExemploCSharp.Views;

public class EmprestarLivroView : IEscolhaUsuario
{
    public void ProcessarEscolha()
    {
        var isbn = ObterISBNLivro();

        var livroService = DependencyInjection.GetService<LivroService>();
        livroService.EmprestarLivro(isbn);

    }

    private int ObterISBNLivro()
    {
        Console.WriteLine("ISBN do livro:");
        var isbn = Utils.Console.ReadLine();

        return int.Parse(isbn);;
    }
}