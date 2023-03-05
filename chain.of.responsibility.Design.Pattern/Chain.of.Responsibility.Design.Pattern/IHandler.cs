namespace Chain.of.Responsibility.Design.Pattern
{
    /// <summary>
    /// The 'Handler' interface
    /// This is the interface that contains a member that holds the next handler in the chain and an associated method to next handler.
    /// It also has a method that must be implemented by concrete classes to handle the request or pass it to the next object in the pipeline.
    /// </summary>
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object? HandleAuthorization(Customer customerRequest);
    }
}
