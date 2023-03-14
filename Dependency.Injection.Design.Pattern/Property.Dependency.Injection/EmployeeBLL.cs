namespace Property.Dependency.Injection
{
    public class EmployeeBLL
    {
        public IEmployeeDAL _employeeDAL { get; set; }

        public List<Employee> GetAllEmployees()
        {
            return _employeeDAL.SelectAllEmployees();
        }
    }
}
