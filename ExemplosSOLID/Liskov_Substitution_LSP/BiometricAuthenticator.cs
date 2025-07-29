namespace ExemplosSOLID.Liskov_Substitution_LSP;

public class BiometricAuthenticator : IAuthenticator
{
    public bool Authenticate(User user)
    => user.FingerprintData != null;
}