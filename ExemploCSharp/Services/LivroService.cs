
using System.Data;
using ExemploCSharp.Entities;
using ExemploCSharp.Interfaces;

namespace ExemploCSharp.Services;
public class LivroService
{
    private readonly ILivroRepository _repository;

    public LivroService(ILivroRepository repository)
        => _repository = repository;

    public void AdicionarLivro(Livro livro)
        => _repository.AdicionarLivro(livro);

    public IEnumerable<Livro> ListarLivros()
        => _repository.ListarLivros();
}