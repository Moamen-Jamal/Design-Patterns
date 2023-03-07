namespace Composite.Design.Pattern
{
    /// <summary>
    /// The 'Leaf' class
    /// The Leaf class represents the end objects of a composition. A leaf can't
    /// have any children.
    /// Usually, it's the Leaf objects that do the actual work, whereas Composite
    /// objects only delegate to their sub-components.    
    /// </summary>
    public class Leaf : IComponent
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public Leaf(string name, int price)
        {
            this.Price = price;
            this.Name = name;
        }

        public void DisplayPrice()
        {
            Console.WriteLine(Name + " : " + Price);
        }
    }
}
