using System.Net;

namespace Prototype.Before
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Address EmpAddress { get; set; }

        public class Address
        {
            public string address { get; set; }
        }
    }
}
