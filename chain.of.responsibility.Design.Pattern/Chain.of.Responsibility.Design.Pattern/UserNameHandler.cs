namespace Chain.of.Responsibility.Design.Pattern
{
    /// <summary>
    /// The 'ConcreteHandlerA' class
    /// This is a concrete handler class inherited from Handler class
    /// These include the functionality to handle some requests and pass others to the next item in the chain of request.
    /// </summary>
    class UserNameHandler : AbstractHandler
    {
        public override object? HandleAuthorization(Customer customerRequest)
        {
            if (!string.IsNullOrEmpty(customerRequest.UserName))
            {
                return $"UserName is correct: UserName of Customer is {customerRequest.UserName}.\n";
            }
            else
            {
                return base.HandleAuthorization(customerRequest);
            }
        }
    }
}
