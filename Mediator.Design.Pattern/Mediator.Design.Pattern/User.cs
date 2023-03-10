namespace Mediator.Design.Pattern
{
    /// <summary>
    /// The 'BaseComponent' class
    /// The Base Component provides the basic functionality of storing a
    /// mediator's instance inside component objects.
    /// </summary>
    public abstract class User
    {
        protected FacebookGroupMediator mediator;
        protected string name;
        public User(FacebookGroupMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }
        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
