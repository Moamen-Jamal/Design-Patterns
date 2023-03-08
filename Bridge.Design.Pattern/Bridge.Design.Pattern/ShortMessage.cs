namespace Bridge.Design.Pattern
{
    /// <summary>
    /// The 'Concrete Abstraction' class
    /// concrete class and implement the AbstractMessage abstract class.
    /// In the constructor, we have initialized the superclass messageSender variable as well as provide the implementation for the SendMessage method.
    /// </summary>
    public class ShortMessage : AbstractMessage
    {
        public ShortMessage(IMessageSender messageSender)
        {
            //Initialize the super class messageSender variable
            this.messageSender = messageSender;
        }

        public override void SendMessage(string Message)
        {
            if (Message.Length <= 10)
            {
                messageSender.SendMessage(Message);
            }
            else
            {
                Console.WriteLine("Unable to send the message as length > 10 characters");
            }
        }
    }
}
