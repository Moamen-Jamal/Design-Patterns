namespace Iterator.Design.Pattern
{
    /// <summary>
    /// The 'Iterator' interface
    /// The Iterator interface declares the operations required for traversing a collection: fetching the next element, retrieving the current position, restarting iteration, etc.
    /// </summary>
    public interface AbstractIterator
    {
        Employee First();
        Employee Next();
        bool IsCompleted { get; }
    }
}
