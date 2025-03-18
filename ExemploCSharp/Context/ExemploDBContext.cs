
using ExemploCSharp.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExemploCSharp.Context;
public class ExemploDBContext : DbContext
{
    public ExemploDBContext(DbContextOptions<ExemploDBContext> options)
        : base(options)
    {
    }

    public ExemploDBContext() { }

    public DbSet<Livro> Livros { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=dev.db");
    }
}