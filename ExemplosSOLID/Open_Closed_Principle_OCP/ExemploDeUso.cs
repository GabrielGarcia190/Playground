namespace ExemplosSOLID.Open_Closed_Principle_OCP;

public class ExemploDeUso
{

    public static void Executar()
    {
        // Uso:
        // Criando dados financeiros
        var data = new FinancialData("5000", "10000");

        // Gerando relatórios em diferentes formatos
        var pdfGenerator = new PdfReportGenerator();
        pdfGenerator.GenerateReport(data);

        var excelGenerator = new ExcelReportGenerator();
        excelGenerator.GenerateReport(data);
    }

}