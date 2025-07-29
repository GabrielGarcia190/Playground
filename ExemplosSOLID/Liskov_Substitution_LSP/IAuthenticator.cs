namespace ExemplosSOLID.Liskov_Substitution_LSP
{
    public interface IAuthenticator
    {
        bool Authenticate(User user);
    }
}