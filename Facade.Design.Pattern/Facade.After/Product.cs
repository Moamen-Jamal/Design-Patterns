namespace Facade.After
{
    /// <summary>
    /// The 'Subsystem' class
    /// The Subsystem can accept requests either from the facade or client directly.
    /// Some facades can work with multiple subsystems at the same time.
    /// </summary>
    public class Product
    {
        public void GetProductDetails()
        {
            Console.WriteLine("Fetching the Product Details");
        }
    }
}
