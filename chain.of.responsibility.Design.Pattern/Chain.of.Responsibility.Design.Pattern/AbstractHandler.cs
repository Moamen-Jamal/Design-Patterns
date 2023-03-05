namespace Chain.of.Responsibility.Design.Pattern
{
    /// <summary>
    /// The 'AbstractHandler' abstract handler
    /// This is the class that contains a member that holds the next handler in the chain and an associated method to next handler.
    /// It also has a method that must be implemented by concrete classes to handle the request or pass it to the next object in the pipeline.
    /// </summary>
    abstract class AbstractHandler : IHandler
    {
        private IHandler? _nextHandler { get; set; }
        public virtual object? HandleAuthorization(Customer customerRequest)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.HandleAuthorization(customerRequest);
            }
            return _nextHandler;
        }

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;

            // Returning a handler from here will let us link handlers in a
            // convenient way like this:
            // userName.SetNext(emailAddress).SetNext(phoneNumber);
            return handler;
        }
    }
}
