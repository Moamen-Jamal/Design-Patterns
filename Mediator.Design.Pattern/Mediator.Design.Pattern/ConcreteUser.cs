namespace Mediator.Design.Pattern
{
    /// <summary>
    /// The 'ConcreteComponents' class
    /// Concrete Components implement various functionality. They don't depend on
    /// other components. They also don't depend on any concrete mediator classes.
    /// </summary>
    public class ConcreteUser : User
    {
        public ConcreteUser(FacebookGroupMediator mediator, string name) : base(mediator, name)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine(name + ": Received Message:" + message);
        }

        public override void Send(string message)
        {
            Console.WriteLine(name + ": Sending Message=" + message + "\n");
            mediator.SendMessage(message, this);
        }
    }
}
