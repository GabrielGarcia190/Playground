namespace ExemplosSOLID.Open_Closed_Principle_OCP;

public class ExcelReportGenerator : ReportGeneratorBase
{
    public override void GenerateReport(FinancialData data)
        => Console.WriteLine($"Gerando Excel: Receita = {data.Revenue}");
}