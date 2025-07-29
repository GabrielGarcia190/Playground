namespace ExemplosSOLID.Liskov_Substitution_LSP;

public class User
{
    public User(string password, string fingerprintData)
    {
        Password = password;
        FingerprintData = fingerprintData;
    }

    public string Password { get; private set; }
    public string FingerprintData { get; private set; }
}