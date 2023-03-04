namespace Decorator.Design.Pattern
{
    /// <summary>
    /// The 'Component' interface
    /// This interface contains members that are going to be implemented by the concrete component classes and decorator.
    /// </summary>
    public interface IPizzaComponent
    {
        string MakePizza();
    }
}
