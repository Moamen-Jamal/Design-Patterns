namespace Visitor.Design.Pattern
{
    /// <summary>
    /// The 'ConcreteVisitor' class
    /// Each Concrete Visitor implements several versions of the same behaviors, tailored for different concrete element classes.
    /// </summary>
    public class Salesman : IVisitor
    {
        public string Name { get; set; }
        public Salesman(string name)
        {
            Name = name;
        }
        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine("Salesman: " + this.Name + " gave the school bag to the child: "
                            + kid.KidName);
        }
    }
}
