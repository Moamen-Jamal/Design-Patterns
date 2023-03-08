namespace Facade.After
{
    /// <summary>
    /// The 'Facade' class
    /// The Facade class provides a simple interface to the complex logic of one
    /// or several subsystems. The Facade delegates the client requests to the
    /// appropriate objects within the subsystem. The Facade is also responsible
    /// for managing their lifecycle. All of this shields the client from the
    /// undesired complexity of the subsystem.
    /// Some facades can work with multiple subsystems at the same time.
    /// </summary>
    public class OrderFacade
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");
            Product product = new Product();
            product.GetProductDetails();
            Payment payment = new Payment();
            payment.MakePayment();
            Invoice invoice = new Invoice();
            invoice.Sendinvoice();
            Console.WriteLine("Order Placed Successfully");
        }
    }
}
