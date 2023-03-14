namespace Constructor.Dependency.Injection
{
    public class EmployeeBLL
    {
        private readonly IEmployeeDAL _employeeDAL;

        public EmployeeBLL(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeDAL.SelectAllEmployees();
        }
    }
}
