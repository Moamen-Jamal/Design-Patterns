namespace Dependency.Injection.Before
{
    public class Client
    {
        public Client()
        {
            EmployeeBLL employeeBL = new EmployeeBLL();
            List<Employee> ListEmployee = employeeBL.GetAllEmployees();
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
            }
        }
       
    }
}
