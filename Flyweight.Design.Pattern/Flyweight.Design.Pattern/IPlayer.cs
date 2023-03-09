namespace Flyweight.Design.Pattern
{
    /// <summary>
    /// The 'Flyweight' interface
    /// declares an interface through which flyweights can receive and act on extrinsic state.
    /// </summary>
    public interface IPlayer
    {
        string Mission { get; set; }
        string Weapon { get; set; }
        void Render();

    }
}
