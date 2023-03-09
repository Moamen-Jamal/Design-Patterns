namespace Template.Method.Before
{
    public class MakeRectanglePizza
    {
        private void BakePizza()
        {
            Console.WriteLine("Baking Pizza ........");
        }
        private void DefinePizzaShape()
        {
            Console.WriteLine("Making Rectangle Pizza");
        }
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
