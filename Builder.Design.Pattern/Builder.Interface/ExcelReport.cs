namespace Builder.Interface
{
    /// <summary>
    /// A 'Concrete Builder' class
    /// The ConcreteBuilder class implements the Builder abstract class and provides implementation to all the abstract methods.
    /// The Concrete Builder is responsible for constructs and assembles the individual parts of the product by implementing the Builder abstract class.
    /// It also defines and tracks the representation it creates.
    /// </summary>
    class ExcelReport : IReportBuilder
    {
        Report reportObject = new();

        public Report GetReport()
        {
            return reportObject;
        }
        public void SetReportContent()
        {
            reportObject.reportContent = "Excel Content Section";
        }
        public void SetReportFooter()
        {
            reportObject.reportFooter = "Excel Footer";
        }
        public void SetReportHeader()
        {
            reportObject.reportHeader = "Excel Header";
        }
        public void SetReportType()
        {
            reportObject.reportType = "Excel";
        }
    }
}
