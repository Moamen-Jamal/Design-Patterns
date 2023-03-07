namespace Composite.Design.Pattern
{
    /// <summary>
    /// The 'Component' interface
    /// interface containing the members that will be implemented by all the child objects in the hierarchy. It also implements some of the behavior that is common to all objects in the composition.
    /// </summary>
    public interface IComponent
    {
        void DisplayPrice();
    }
}
