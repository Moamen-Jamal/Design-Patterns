namespace Builder.AbstractClass
{
    /// <summary>
    /// A 'Director' class
    /// The Director takes those individual processes from the Builder and defines the sequence to build the product.
    /// </summary>
    public class ReportDirector
    {
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();

            return reportBuilder.GetReport();
        }
    }
}
