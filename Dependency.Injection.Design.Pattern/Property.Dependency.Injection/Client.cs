namespace Property.Dependency.Injection
{
    public class Client
    {
        public Client()
        {
            EmployeeBLL employeeBL = new EmployeeBLL();
            employeeBL._employeeDAL = new EmployeeDAL();
            List<Employee> ListEmployee = employeeBL.GetAllEmployees();
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
            }
        }
       
    }
}
