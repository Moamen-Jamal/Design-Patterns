namespace Decorator.Design.Pattern
{
    /// <summary>
    /// The 'Decorator' class
    /// This is an abstract class.
    /// This class implements the Component interface and contains a reference to a component instance.
    /// This class also acts as the base class for all decorators.
    /// The decorator is essentially wrapping the Component.
    /// </summary>
    public abstract class PizzaDecorator : IPizzaComponent
    {
        protected IPizzaComponent pizza;
        public PizzaDecorator(IPizzaComponent pizza)
        {
            this.pizza = pizza;
        }
        public virtual string MakePizza()
        {
            return pizza.MakePizza();
        }
    }
}
