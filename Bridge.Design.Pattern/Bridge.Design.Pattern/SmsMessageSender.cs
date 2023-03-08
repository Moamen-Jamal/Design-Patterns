namespace Bridge.Design.Pattern
{
    /// <summary>
    /// The 'Concrete Implementation' class
    /// Each Concrete Implementation corresponds to a specific platform and implements the Implementation interface.
    /// </summary>
    public class SmsMessageSender : IMessageSender
    {
        public void SendMessage(string Message)
        {
            Console.WriteLine("'" + Message + "'   : This Message has been sent using SMS");
        }
    }
}
