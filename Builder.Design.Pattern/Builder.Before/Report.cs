namespace Builder.Before
{
    public class Report
    {
        public string reportType { get; set; }
        public string reportHeader { get; set; }
        public string reportFooter { get; set; }
        public string reportContent { get; set; }

        public Report(string reportType, string reportHeader, string reportFooter, string reportContent)
        {
            this.reportType = reportType;
            this.reportHeader = reportHeader;
            this.reportFooter = reportFooter;
            this.reportContent = reportContent;
        }
        public void DisplayReport()
        {
            Console.WriteLine("Report Type :" + reportType);
            Console.WriteLine("Header :" + reportHeader);
            Console.WriteLine("Content :" + reportContent);
            Console.WriteLine("Footer :" + reportFooter);
        }
    }
}
