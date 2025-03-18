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

    public void DevolverLivro(int isbn)
    {
        var livro = _context.Livros.FirstOrDefault(l => l.ISBN == isbn);

        if (livro is null) return;

        livro.Disponivel = true;
        _context.SaveChanges();
    }

    public void EmprestarLivro(int isbn)
    {
        var livro = _context.Livros.FirstOrDefault(l => l.ISBN == isbn);

        if (livro is null) return;

        livro.Disponivel = false;
        _context.SaveChanges();
    }

    public IEnumerable<Livro> ListarLivros()
        => _context.Livros.ToList();
}