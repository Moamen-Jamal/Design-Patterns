namespace Builder.AbstractClass
{
    /// <summary>
    /// A 'Concrete Builder' class
    /// The ConcreteBuilder class implements the Builder abstract class and provides implementation to all the abstract methods.
    /// The Concrete Builder is responsible for constructs and assembles the individual parts of the product by implementing the Builder abstract class.
    /// It also defines and tracks the representation it creates.
    /// </summary>
    public class PDFReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.reportContent = "PDF Content Section";
        }
        public override void SetReportFooter()
        {
            reportObject.reportFooter = "PDF Footer";
        }
        public override void SetReportHeader()
        {
            reportObject.reportHeader = "PDF Header";
        }
        public override void SetReportType()
        {
            reportObject.reportType = "PDF";
        }
    }
}
