using System.Collections;

namespace Iterator.Design.Pattern
{
    /// <summary>
    /// The 'ConcreteAggregate' (Concrete Collections) class
    /// implements the Iterator creation interface to return an instance of the proper ConcreteIterator.
    /// Concrete Collections return new instances of a particular concrete iterator class each time the client requests one.
    /// </summary>
    public class CompanyBEmployees : AbstractCollection, BaseCompany
    {
        private ArrayList arrayListEmployees = new ArrayList();

        //Create Iterator
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        // Gets item count
        public int Count
        {
            get { return arrayListEmployees.Count; }
        }
        //Add items to the collection
        public void AddEmployee(Employee employee)
        {
            arrayListEmployees.Add(employee);
        }
        //Get item from collection
        public Employee GetEmployee(int IndexPosition)
        {
            return (Employee)arrayListEmployees[IndexPosition];
        }
    }
}
