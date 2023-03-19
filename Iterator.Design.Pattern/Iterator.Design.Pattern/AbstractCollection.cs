namespace Iterator.Design.Pattern
{
    /// <summary>
    /// The 'Aggregate' (AbstractCollection) interface
    /// defines an interface for creating an Iterator object.
    /// The Collection interface declares one or multiple methods for getting iterators compatible with the collection.
    /// Note that the return type of the methods must be declared as the iterator interface so that the concrete collections can return various kinds of iterators.
    /// </summary>
    public interface AbstractCollection
    {
        Iterator CreateIterator();
    }
}
