namespace Bridge.Design.Pattern
{
    /// <summary>
    /// The 'Abstraction' class
    /// The Abstraction defines the interface for the "control" part of the two
    /// class hierarchies. It maintains a reference to an object of the
    /// Implementation hierarchy and delegates all of the real work to this object.
    /// </summary>
    public abstract class AbstractMessage
    {
        protected IMessageSender messageSender;
        public abstract void SendMessage(string Message);
    }
}
