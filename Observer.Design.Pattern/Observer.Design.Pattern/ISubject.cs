namespace Observer.Design.Pattern
{
    /// <summary>
    /// The 'publisher' interface
    /// When a change occurs to a subject it should notify all of its subscribers 'observers'.
    /// </summary>
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
