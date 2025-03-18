using ExemploCSharp.Interfaces;

namespace ExemploCSharp.Views
{
    public class SairView : IEscolhaUsuario
    {
        public void ProcessarEscolha()
        {
            Console.WriteLine("Saindo...");
            Environment.Exit(0);
        }
    }
}