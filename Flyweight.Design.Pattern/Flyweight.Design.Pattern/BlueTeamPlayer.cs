namespace Flyweight.Design.Pattern
{
    /// <summary>
    /// The 'ConcreteFlyweight' class
    /// implements the Flyweight interface and adds storage for intrinsic state, if any. 
    /// A ConcreteFlyweight object must be sharable. Any state it stores must be intrinsic, that is, it must be independent of the ConcreteFlyweight object's context.
    /// </summary>
    public class BlueTeamPlayer : IPlayer
    {
        public string Mission { get; set; } = "Capture Blue Flag";
        public string Weapon { get; set; }

        public void Render()
        {
            Console.WriteLine($"Weapon: {Weapon} and Mission: {Mission}");
        }
    }
}
