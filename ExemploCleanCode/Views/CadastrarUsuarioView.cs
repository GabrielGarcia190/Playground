using ExemploCSharp.Entities;
using ExemploCSharp.Interfaces;
using ExemploCSharp.Ioc;
using ExemploCSharp.Services;

namespace ExemploCSharp.Views;

public class CadastrarUsuarioView : IEscolhaUsuario
{
    public void ProcessarEscolha()
    {
        var usuario = ObterInformacoesUsuario();

        var usuarioService = DependencyInjection.GetService<UsuarioService>();
        usuarioService.CadastrarUsuario(usuario);

    }

    private Usuario ObterInformacoesUsuario()
    {
        Console.WriteLine("Nome:");
        var nome = Utils.Console.ReadLine();

        return new Usuario(nome);
    }
}