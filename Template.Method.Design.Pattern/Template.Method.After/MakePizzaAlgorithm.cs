namespace Template.Method.After
{
    /// <summary>
    /// The 'AbstractClass' class
    /// The Abstract Class declares methods that act as steps of an algorithm, as well as the actual template method which calls these methods in a specific order.
    /// The steps may either be declared abstract or have some default implementation.
    /// </summary>
    public abstract class MakePizzaAlgorithm
    {
        private void BakePizza()
        {
            Console.WriteLine("Baking Pizza ........");
        }
        public abstract void DefinePizzaShape();

        private void PutAddons()
        {
            Console.WriteLine("Putting Pizza Addons........");
        }
        private void HeatingPizza()
        {
            Console.WriteLine("Heating Pizza........");
        }
        public void MakePizza()
        {
            BakePizza();
            DefinePizzaShape();
            PutAddons();
            HeatingPizza();

        }
    }
}
