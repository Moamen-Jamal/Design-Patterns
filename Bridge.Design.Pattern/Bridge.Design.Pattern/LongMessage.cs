namespace Bridge.Design.Pattern
{
    /// <summary>
    /// The 'Concrete Abstraction' class
    /// concrete class and implement the AbstractMessage abstract class.
    /// In the constructor, initialize the messageSender variable and provide the implementation for the SendMessage method.
    /// </summary>
    public class LongMessage : AbstractMessage
    {
        public LongMessage(IMessageSender messageSendor)
        {
            messageSender = messageSendor;
        }
        public override void SendMessage(string Message)
        {
            messageSender.SendMessage(Message);
        }
    }
}
