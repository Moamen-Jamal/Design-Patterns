namespace Visitor.Design.Pattern
{
    /// <summary>
    /// The 'Element' interface
    /// The Element interface declares a method for “accepting” visitors. This method should have one parameter declared with the type of the visitor interface.
    /// </summary>
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
