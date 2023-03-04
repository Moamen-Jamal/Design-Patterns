namespace Builder.Interface
{
    /// <summary>
    /// A 'Builder' interface
    /// The Builder is an abstract class that defines all the steps which are used to make the concrete product. 
    /// </summary>
    public interface IReportBuilder
    {
        void SetReportType();
        void SetReportHeader();
        void SetReportContent();
        void SetReportFooter();
        Report GetReport();
    }
}
