namespace Prototype.After
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Address EmpAddress { get; set; }

        //Copy all without Object Reference (address)
        public Employee ShallowCopy()
        {
            return (Employee)this.MemberwiseClone();

        }

        //Copy all
        public Employee DeepCopy()
        {
            Employee employee = (Employee)this.MemberwiseClone();
            employee.EmpAddress = EmpAddress.ShallowCopy();
            return employee;
        }

        public class Address
        {
            public string address { get; set; }
            public Address ShallowCopy()
            {
                return (Address)this.MemberwiseClone();
            }
        }

        
    }
}
