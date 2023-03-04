namespace Decorator.Design.Pattern
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// This is going to be a concrete class.
    /// This class simply implements the Component interface.
    /// </summary>
    public class PlainPizzaConcreteComponent : IPizzaComponent
    {
        public string MakePizza()
        {
            return "Plain Pizza";
        }
    }
}
