namespace Composite.Design.Pattern
{
    /// <summary>
    /// The 'Composite' class
    /// The Composite class represents the complex components that may have
    /// children. Usually, the Composite objects delegate the actual work to
    /// their children and then "sum-up" the result.
    /// </summary>
    public class Composite : IComponent
    {
        public string Name { get; set; }
        List<IComponent> components = new List<IComponent>();
        public Composite(string name)
        {
            Name = name;
        }
        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }

        public void DisplayPrice()
        {
            Console.WriteLine(Name);
            foreach (var item in components)
            {
                item.DisplayPrice();
            }
        }
    }
}
