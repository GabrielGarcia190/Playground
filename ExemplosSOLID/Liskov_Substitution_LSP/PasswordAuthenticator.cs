namespace ExemplosSOLID.Liskov_Substitution_LSP;

public class PasswordAuthenticator : IAuthenticator
{
    public bool Authenticate(User user)
    => user.Password == "123456";
}