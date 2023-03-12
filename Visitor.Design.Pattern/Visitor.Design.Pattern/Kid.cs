namespace Visitor.Design.Pattern
{
    /// <summary>
    /// The 'ConcreteElement' class
    /// Each Concrete Element must implement the acceptance method.
    /// The purpose of this method is to redirect the call to the proper visitor’s method corresponding to the current element class. 
    /// Be aware that even if a base element class implements this method, all subclasses must still override this method in their own classes and call the appropriate method on the visitor object.
    /// </summary>
    public class Kid : IElement
    {
        public string KidName { get; set; }

        public Kid(string name)
        {
            KidName = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
