namespace Builder.AbstractClass
{
    /// <summary>
    /// A 'Builder' abstract class
    /// The Builder is an abstract class that defines all the steps which are used to make the concrete product. 
    /// </summary>
    public abstract class ReportBuilder
    {
        protected Report reportObject;
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();
        public void CreateNewReport()
        {
            reportObject = new Report();
        }
        public Report GetReport()
        {
            return reportObject;
        }
    }
}
