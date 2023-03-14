namespace Method.Dependency.Injection
{
    public class EmployeeBLL : IDataAccessDependency
    {
       IEmployeeDAL _employeeDAL { get; set; }

        public List<Employee> GetAllEmployees()
        {
            return _employeeDAL.SelectAllEmployees();
        }

        public void SetDependency(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }
    }
}
