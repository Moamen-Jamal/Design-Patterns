namespace Decorator.Design.Pattern
{
    /// <summary>
    /// The 'ConcreteDecoratorA' class
    /// This is concrete classes and inherited from the Decorator abstract class.
    /// This class adds additional responsibility to the original component.
    /// </summary>
    public class ChickenPizzaConcerateDecorator : PizzaDecorator
    {
        public ChickenPizzaConcerateDecorator(IPizzaComponent pizza) : base(pizza)
        {
        }
        public override string MakePizza()
        {
            return pizza.MakePizza() + AddChicken();
        }
        private string AddChicken()
        {
            return ", Chicken added";
        }
    }
}
