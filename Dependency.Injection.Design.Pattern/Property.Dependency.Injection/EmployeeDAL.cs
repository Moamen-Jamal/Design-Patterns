namespace Property.Dependency.Injection
{
    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>();
            //Get the Employees from the Database
            //for now we are hard coded the employees
            ListEmployees.Add(new Employee() { ID = 1, Name = "Moamen", Department = "IT" });
            ListEmployees.Add(new Employee() { ID = 2, Name = "Jamal", Department = "HR" });
            ListEmployees.Add(new Employee() { ID = 3, Name = "Sara", Department = "Payroll" });
            return ListEmployees;
        }

    }
}
