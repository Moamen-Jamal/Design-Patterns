namespace Adapter.Class.Design.Pattern
{
    [Serializable]
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        //This Parameterless Constructor for XmlSerializer
        public Employee()
        {}
        public Employee(int iD, string name)
        {
            ID = iD;
            Name = name;
        }
    }
}
