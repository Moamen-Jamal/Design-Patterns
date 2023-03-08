namespace Facade.After
{
    /// <summary>
    /// The 'Subsystem' class
    /// The Subsystem can accept requests either from the facade or client directly.
    /// Some facades can work with multiple subsystems at the same time.
    /// </summary>
    public class Payment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment Done Successfully");
        }
    }
}
