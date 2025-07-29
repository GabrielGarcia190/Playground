namespace ExemplosSOLID.Open_Closed_Principle_OCP;

public class PdfReportGenerator : ReportGeneratorBase
{
    public override void GenerateReport(FinancialData data)
        => Console.WriteLine($"Gerando PDF: Saldo = {data.Balance}");
}