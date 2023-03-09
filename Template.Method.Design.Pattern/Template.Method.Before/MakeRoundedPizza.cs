namespace Template.Method.Before
{
    public class MakeRoundedPizza
    {
        private void BakePizza()
        {
            Console.WriteLine("Baking Pizza ........");
        }
        private void DefinePizzaShape()
        {
            Console.WriteLine("Making the pizza rounded");
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
