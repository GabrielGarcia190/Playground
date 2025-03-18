using ExemploCSharp.Context;
using ExemploCSharp.Entities;

namespace ExemploCSharp.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ExemploDBContext _context;
        public UsuarioRepository(ExemploDBContext context)
            => _context = context;

        public void CadastrarUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public IEnumerable<Usuario> ListarUsuarios()
            => _context.Usuarios.ToList();
    }
}