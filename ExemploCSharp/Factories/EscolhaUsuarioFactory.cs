using ExemploCSharp.Interfaces;
using ExemploCSharp.Views;

namespace ExemploCSharp.Factories
{
    public static class EscolhaUsuarioFactory
    {
        public static IEscolhaUsuario RetornarEscolhaUsuario(string? escolha)
        {
            switch (escolha)
            {
                case "1":
                    return new AdicionarLivroView();
                case "2":
                    return new ListarLivrosView();
                case "3":
                    return new CadastrarUsuarioView();
                case "4":
                    return new ListarUsuariosView();
                case "5":
                    return new EmprestarLivroView();
                case "6":
                    return new DevolverLivroView();
                case "7":
                    return new SairView();
                default:
                    throw new Exception("Escolha inválida");
            }
        }
    }
}