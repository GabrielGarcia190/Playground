namespace ExemplosSOLID.Open_Closed_Principle_OCP;

public class FinancialData
{
    public FinancialData(string balance, string revenue)
    {
        Balance = balance;
        Revenue = revenue;
    }

    public string Balance { get; private set; }
    public string Revenue { get; private set; }
}