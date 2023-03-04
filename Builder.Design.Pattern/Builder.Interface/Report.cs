namespace Builder.Interface
{
    /// <summary>
    /// A 'Product' class
    /// The Product is a class and we want to create this product object using the builder design pattern. 
    /// This class defines different parts that will make the product.
    /// </summary>
    public class Report
    {
        public string reportType { get; set; }
        public string reportHeader { get; set; }
        public string reportFooter { get; set; }
        public string reportContent { get; set; }

        public void DisplayReport()
        {
            Console.WriteLine("Report Type :" + reportType);
            Console.WriteLine("Header :" + reportHeader);
            Console.WriteLine("Content :" + reportContent);
            Console.WriteLine("Footer :" + reportFooter);
        }
    }
}
