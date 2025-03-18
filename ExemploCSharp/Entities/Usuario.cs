
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExemploCSharp.Entities;

[Table("Usuarios")]
public class Usuario
{
    public Usuario(string nome)
    {
        Nome = nome;
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Nome { get; set; }
}