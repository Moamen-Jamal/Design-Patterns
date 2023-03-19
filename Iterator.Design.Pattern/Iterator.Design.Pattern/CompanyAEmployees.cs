namespace Iterator.Design.Pattern
{
    /// <summary>
    /// The 'ConcreteAggregate' (Concrete Collections) class
    /// implements the Iterator creation interface to return an instance of the proper ConcreteIterator.
    /// Concrete Collections return new instances of a particular concrete iterator class each time the client requests one.
    /// </summary>
    public class CompanyAEmployees : AbstractCollection, BaseCompany
    {
        private List<Employee> listEmployees = new List<Employee>();

        //Create Iterator
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        // Gets item count
        public int Count
        {
            get { return listEmployees.Count; }
        }
        //Add items to the collection
        public void AddEmployee(Employee employee)
        {
            listEmployees.Add(employee);
        }
        //Get item from collection
        public Employee GetEmployee(int IndexPosition)
        {
            return listEmployees[IndexPosition];
        }
    }
}
