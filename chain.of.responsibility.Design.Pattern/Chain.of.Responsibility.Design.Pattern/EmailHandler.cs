namespace Chain.of.Responsibility.Design.Pattern
{
    /// <summary>
    /// The 'ConcreteHandlerB' class
    /// This is a concrete handler class inherited from Handler class
    /// These include the functionality to handle some requests and pass others to the next item in the chain of request.
    /// </summary>
    class EmailHandler : AbstractHandler
    {
        public override object? HandleAuthorization(Customer customerRequest)
        {
            if (!string.IsNullOrEmpty(customerRequest.Email))
            {
                return $"Email is correct: Email of Customer is {customerRequest.Email}.\n";
            }
            else
            {
                return base.HandleAuthorization(customerRequest);
            }
        }
    }
}
