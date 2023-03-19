namespace Iterator.Design.Pattern
{
    /// <summary>
    /// The 'Concrete Iterators' class
    /// Concrete Iterators implement specific algorithms for traversing a collection.
    /// The iterator object should track the traversal progress on its own.
    /// This allows several iterators to traverse the same collection independently of each other.
    /// </summary>
    public class Iterator : AbstractIterator
    {
        private BaseCompany collection;
        private int current = 0;
        private int step = 1;

        // Constructor
        public Iterator(BaseCompany collection)
        {
            this.collection = collection;
        }

        // Gets first item
        public Employee First()
        {
            current = 0;
            return collection.GetEmployee(current);
        }

        // Gets next item
        public Employee Next()
        {
            current += step;
            if (!IsCompleted)
            {
                return collection.GetEmployee(current);
            }
            else
            {
                return null;
            }
        }

        // Check whether iteration is complete
        public bool IsCompleted
        {
            get { return current >= collection.Count; }
        }
    }
}
