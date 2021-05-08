using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var excelBuilder = new ExcelReportBuilder();
            var pdfBuilder = new PDFReportBuilder();

            ReportDirector director = new ReportDirector();
            director.Builder = excelBuilder;
            director.BuildReport();

            var excelReport = excelBuilder.GetReport();
            director.Builder = pdfBuilder;
            director.BuildReport();

            var pdfReport = pdfBuilder.GetReport();



            Process(excelReport);
            Process(pdfReport);
            
        }

         public static void Process(IReport logger)
        {
            logger.Log("Client message.");
        }
    }

    
}
