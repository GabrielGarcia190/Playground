namespace ExemplosSOLID.Liskov_Substitution_LSP;

public static class ExemploDeUso
{
    public static void Executar()
    {
        var user = new User(password: "123456", fingerprintData: "fingerprint123");

        var authenticators = new List<IAuthenticator> { new PasswordAuthenticator(), new BiometricAuthenticator() };

        foreach (var auth in authenticators)
            Console.WriteLine(auth.Authenticate(user) ? "Autenticado" : "Falha");
    }
}