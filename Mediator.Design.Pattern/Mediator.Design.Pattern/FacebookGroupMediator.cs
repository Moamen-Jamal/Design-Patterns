namespace Mediator.Design.Pattern
{
    /// <summary>
    /// The 'Mediator' interface
    /// The Mediator interface declares a method used by components to notify the
    /// mediator about various events. The Mediator may react to these events and
    /// pass the execution to other components.
    /// </summary>
    public interface FacebookGroupMediator
    {
        void SendMessage(string msg, User user);
        void RegisterUser(User user);
    }
}
