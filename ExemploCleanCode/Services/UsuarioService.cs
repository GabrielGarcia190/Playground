using ExemploCSharp.Entities;

namespace ExemploCSharp.Services;

public class UsuarioService
{
    private readonly IUsuarioRepository _repository;

    public UsuarioService(IUsuarioRepository repository)
        => _repository = repository;

    public void CadastrarUsuario(Usuario usuario)
        => _repository.CadastrarUsuario(usuario);

    public IEnumerable<Usuario> ListarUsuarios()
        => _repository.ListarUsuarios();
}