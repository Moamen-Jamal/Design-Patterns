namespace Bridge.Design.Pattern
{
    /// <summary>
    /// The 'Concrete Implementation' class
    /// Each Concrete Implementation corresponds to a specific platform and implements the Implementation interface.
    /// </summary>
    public class EmailMessageSender : IMessageSender
    {
        public void SendMessage(string Message)
        {
            Console.WriteLine("'" + Message + "'   : This Message has been sent using Email");
        }
    }
}
