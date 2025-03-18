using ExemploCSharp.Entities;

public interface IUsuarioRepository
{
    void CadastrarUsuario(Usuario usuario);

    IEnumerable<Usuario> ListarUsuarios();
}