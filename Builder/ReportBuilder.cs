namespace Builder
{
    public abstract class ReportBuilder
    {
        public abstract void CreateNewReport();
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();

    }

    public class ReportDirector
    {
        public ReportBuilder Builder { get; set; }

        public void BuildReport()
        {
            Builder.CreateNewReport();
            Builder.SetReportType();
            Builder.SetReportHeader();
            Builder.SetReportContent();
            Builder.SetReportFooter();

        }

    }

    public class ExcelReportBuilder : ReportBuilder
    {
        private string _reportType;
        private string _header;
        private string _content;
        private string _footer;

        public ExcelReport GetReport()
        {
            var report = new ExcelReport();
            report.SetReportType(_reportType);
            report.SetReportHeader(_header);
            report.SetReportContent(_content);
            report.SetReportFooter(_footer);
            return report;
        }
        public override void CreateNewReport()
        {
            
        }

        public override void SetReportContent()
        {
            _content = "Excel Content Section";
        }

        public override void SetReportFooter()
        {
            _footer = "Excel Footer";
        }

        public override void SetReportHeader()
        {
            _header = "Excel Header";
        }

        public override void SetReportType()
        {
            _reportType = "Excel";
        }
    }

    public class PDFReportBuilder : ReportBuilder
    {
        private string _reportType;
        private string _header;
        private string _content;
        private string _footer;

        public PDFReport GetReport()
        {
            var report = new PDFReport();
            report.SetReportType(_reportType);
            report.SetReportHeader(_header);
            report.SetReportContent(_content);
            report.SetReportFooter(_footer);
            return report;
        }
        public override void CreateNewReport()
        {
            
        }

        public override void SetReportContent()
        {
            _content = "PDF Content Section";
        }

        public override void SetReportFooter()
        {
            _footer = "PDF Footer";
        }

        public override void SetReportHeader()
        {
            _header = "PDF Header";
        }

        public override void SetReportType()
        {
            _reportType = "PDF";
        }
    }

}