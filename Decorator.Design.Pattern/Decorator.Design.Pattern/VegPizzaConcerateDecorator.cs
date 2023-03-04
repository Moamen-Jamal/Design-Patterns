namespace Decorator.Design.Pattern
{
    /// <summary>
    /// The 'ConcreteDecoratorB' class
    /// This is concrete classes and inherited from the Decorator abstract class.
    /// This class adds additional responsibility to the original component.
    /// </summary>
    public class VegPizzaConcerateDecorator : PizzaDecorator
    {
        public VegPizzaConcerateDecorator(IPizzaComponent pizza) : base(pizza)
        {
        }
        public override string MakePizza()
        {
            return pizza.MakePizza() + AddVegetables();
        }
        private string AddVegetables()
        {
            return ", Vegetables added";
        }
    }
}
