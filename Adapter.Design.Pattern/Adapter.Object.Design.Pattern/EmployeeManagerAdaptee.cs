using System.Xml;
using System.Xml.Serialization;

namespace Adapter.Object.Design.Pattern
{
    /// <summary>
    /// A 'Adaptee' class
    /// This class contains the functionality which the client requires but it’s not compatible with the existing client code. 
    /// So, it requires some adaptation before the client code can use it. 
    /// It means the client will call the Adapter and the Adapter will do the conversion if required and then it will make a call to the Adaptee.
    /// </summary>
    public class EmployeeManagerAdaptee
    {
        public List<Employee> Employees = new List<Employee>();

        public EmployeeManagerAdaptee()
        {
            Employees.Add(new Employee(1, "Ahmed"));
            Employees.Add(new Employee(2, "Amr"));
            Employees.Add(new Employee(3, "Ali"));
        }

        public string GetAllEmpolyees()
        {
            var emptyNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serialize = new XmlSerializer(Employees.GetType());

            var settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            using (var stream = new StringWriter())
                using (var writer = XmlWriter.Create(stream, settings))
            {
                serialize.Serialize(writer, Employees, emptyNamespaces);
                return stream.ToString();
            }

        }
    }
}
