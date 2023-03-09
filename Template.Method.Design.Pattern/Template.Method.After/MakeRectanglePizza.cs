namespace Template.Method.After
{
    /// <summary>
    /// The 'Concrete Class' class
    /// Concrete Class can override all of the steps, but not the template method itself.
    /// </summary>
    public class MakeRectanglePizza : MakePizzaAlgorithm
    {
        public override void DefinePizzaShape()
        {
            Console.WriteLine("Making Rectangle Pizza");
        }
    }
}
