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
                // case "3":
                //     return new RegistrarUsuario();
                // case "4":
                //     return new EmprestarLivro();
                // case "5":
                //     return new DevolverLivro();
                // case "6":
                //     return new Sair();
                default:
                    throw new Exception("Escolha inválida");
            }
        }
    }
}