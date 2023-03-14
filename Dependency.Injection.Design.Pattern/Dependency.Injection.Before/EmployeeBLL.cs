namespace Dependency.Injection.Before
{
    public class EmployeeBLL
    {
        public EmployeeDAL employeeDAL;

        public List<Employee> GetAllEmployees()
        {
            employeeDAL = new EmployeeDAL();
            return employeeDAL.SelectAllEmployees();
        }
    }
}
