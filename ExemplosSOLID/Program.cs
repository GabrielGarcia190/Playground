internal class Program
{
    private static void Main(string[] args)
    {

        ExemplosSOLID.Dependency_Inversion_DIP.DependencyInjection.ConfigureServices();

        Console.WriteLine("================Exemplos SOLID================");
        Console.WriteLine("======== SRP - Reponsabilidade Unica =========");
        ExemplosSOLID.Responsabilidade_Unica_SRP.ExemploDeUso.Executar();
        Console.WriteLine("==============================================");
        Console.WriteLine("============ OCP - Open/Closed  ==============");
        ExemplosSOLID.Open_Closed_Principle_OCP.ExemploDeUso.Executar();
        Console.WriteLine("==============================================");
        Console.WriteLine("======== LSP - Liskov Substitution  ==========");
        ExemplosSOLID.Liskov_Substitution_LSP.ExemploDeUso.Executar();
        Console.WriteLine("==============================================");
        Console.WriteLine("======== ISP - Interface Segregation =========");
        ExemplosSOLID.Interface_Segregation_ISP.ExemploDeUso.Executar();
        Console.WriteLine("==============================================");
        Console.WriteLine("======== ISP - Dependency Inversion ==========");
        ExemplosSOLID.Dependency_Inversion_DIP.ExemploDeUso.Executar();
        Console.WriteLine("==============================================");
    }
}
