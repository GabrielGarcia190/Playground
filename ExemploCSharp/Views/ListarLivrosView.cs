using ExemploCSharp.Entities;
using ExemploCSharp.Interfaces;
using ExemploCSharp.Ioc;
using ExemploCSharp.Services;

namespace ExemploCSharp.Views;

public class ListarLivrosView : IEscolhaUsuario
{
    public void ProcessarEscolha()
    {
        var livroService = DependencyInjection.GetService<LivroService>();
        var livros = livroService.ListarLivros();

        ExibirLivros(livros);
    }

    private void ExibirLivros(IEnumerable<Livro> livros)
    {
        foreach (var livro in livros)
        {
            Console.WriteLine($"============{livro.ISBN}=============");
            Console.WriteLine($"Título: {livro.Titulo}");
            Console.WriteLine($"Autor: {livro.Autor}");
            Console.WriteLine($"Diponível: {livro.Disponivel}");
            Console.WriteLine("======================================");
        }
    }
}