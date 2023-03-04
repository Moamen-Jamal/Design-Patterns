namespace Builder.Interface
{
    /// <summary>
    /// A 'Director' class
    /// The Director takes those individual processes from the Builder and defines the sequence to build the product.
    /// </summary>
    public class ReportDirector
    {
        public Report MakeReport(IReportBuilder reportBuilder)
        {
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();

            return reportBuilder.GetReport();
        }
    }
}
