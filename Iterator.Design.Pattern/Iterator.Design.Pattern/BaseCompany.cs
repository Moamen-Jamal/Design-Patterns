namespace Iterator.Design.Pattern
{
    public interface BaseCompany
    {
        void AddEmployee(Employee employee);
        Employee GetEmployee(int IndexPosition);
        int Count { get; }
    }
}
