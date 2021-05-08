using System;
using System.IO;
namespace Builder
{
    public interface IReport
    {
        void Log(string message);
    }


    public class ExcelReport: IReport
    {
        public void Log(string message) 
        {
            Console.WriteLine($"{message} - ExcelReport");
        }


        public void SetReportType(string report){}
        public void SetReportHeader(string report){}
        public void SetReportContent(string report){}
        public void SetReportFooter(string report){}
    }


    public class PDFReport: IReport
    {
        public void Log(string message) 
        {
            Console.WriteLine($"{message} - PDFReport");
        }

        
        public void SetReportType(string report){}
        public void SetReportHeader(string report){}
        public void SetReportContent(string report){}
        public void SetReportFooter(string report){}
    }
}