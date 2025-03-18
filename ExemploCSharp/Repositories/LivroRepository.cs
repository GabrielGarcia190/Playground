using ExemploCSharp.Context;
using ExemploCSharp.Entities;
using ExemploCSharp.Interfaces;

namespace ExemploCSharp.Repositories;

public class LivroRepository : ILivroRepository
{
    private readonly ExemploDBContext _context;

    public LivroRepository(ExemploDBContext context)
        => _context = context;

    public void AdicionarLivro(Livro livro)
    {
        _context.Livros.Add(livro);
        _context.SaveChanges();
    }

    public void DevolverLivro(string isbn)
    {
        throw new NotImplementedException();
    }

    public void EmprestarLivro(string isbn)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Livro> ListarLivros()
        => _context.Livros.ToList();
}