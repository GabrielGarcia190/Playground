using ExemploCSharp.Entities;

namespace ExemploCSharp.Interfaces;

public interface ILivroRepository
{
    void AdicionarLivro(Livro livro);
    IEnumerable<Livro> ListarLivros();
    void EmprestarLivro(int isbn);
    void DevolverLivro(int isbn);
}