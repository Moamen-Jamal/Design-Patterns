namespace Facade.After
{
    /// <summary>
    /// The 'Subsystem' class
    /// The Subsystem can accept requests either from the facade or client directly.
    /// Some facades can work with multiple subsystems at the same time.
    /// </summary>
    public class Invoice
    {
        public void Sendinvoice()
        {
            Console.WriteLine("Invoice Send Successfully");
        }
    }
}
