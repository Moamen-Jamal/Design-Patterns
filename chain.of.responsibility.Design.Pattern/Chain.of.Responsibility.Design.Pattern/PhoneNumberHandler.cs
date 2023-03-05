namespace Chain.of.Responsibility.Design.Pattern
{
    /// <summary>
    /// The 'ConcreteHandlerC' class
    /// This is a concrete handler class inherited from Handler class
    /// These include the functionality to handle some requests and pass others to the next item in the chain of request.
    /// </summary>
    class PhoneNumberHandler : AbstractHandler
    {
        public override object? HandleAuthorization(Customer customerRequest)
        {
            if (!string.IsNullOrEmpty(customerRequest.PhoneNumber))
            {
                return $"PhoneNumber is correct: Email of Customer is {customerRequest.PhoneNumber}.\n";
            }
            else
            {
                return base.HandleAuthorization(customerRequest);
            }
        }
    }
}
