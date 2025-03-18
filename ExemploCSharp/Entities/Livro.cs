using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExemploCSharp.Entities;

[Table("Livros")]
public class Livro
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ISBN { get; private set; }

    [Required(ErrorMessage = "O título é obrigatório.")]
    public string Titulo { get; private set; }

    [Required(ErrorMessage = "O autor é obrigatório.")]
    public string Autor { get; private set; }
    
    public bool Disponivel { get; private set; } = true;

    public Livro(string titulo, string autor)
    {
        Titulo = titulo ?? throw new ArgumentNullException(nameof(titulo));
        Autor = autor ?? throw new ArgumentNullException(nameof(autor));
    }

    private Livro() { }
}