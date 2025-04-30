using ExemploCSharp.Interfaces;
using ExemploCSharp.Ioc;
using ExemploCSharp.Services;

namespace ExemploCSharp.Views
{
    public class ListarUsuariosView : IEscolhaUsuario
    {
        public void ProcessarEscolha()
        {
            var usuarioService = DependencyInjection.GetService<UsuarioService>();
            var usuarios = usuarioService.ListarUsuarios();

            ExibirUsuarios(usuarios);
        }

        private static void ExibirUsuarios(IEnumerable<Entities.Usuario> usuarios)
        {
            foreach (var usuario in usuarios)
            {
                Console.WriteLine($"========= {usuario.Id} =========");
                Console.WriteLine($"Nome: {usuario.Nome}");
                Console.WriteLine("==============================");
            }
        }
    }
}