namespace Visitor.Design.Pattern
{
    /// <summary>
    /// The 'Client' class
    /// The Client usually represents a collection or some other complex object (for example, a Composite tree). 
    /// Usually, clients aren’t aware of all the concrete element classes because they work with objects from that collection via some abstract interface.
    /// </summary>
    public class School
    {
        private static List<IElement> elements;
        static School()
        {
            elements = new List<IElement>
            {
                new Kid("Ram"),
                new Kid("Sara"),
                new Kid("Pam")
            };
        }
        public void PerformOperation(IVisitor visitor)
        {
            foreach (var kid in elements)
            {
                kid.Accept(visitor);
            }
        }
    }
}
