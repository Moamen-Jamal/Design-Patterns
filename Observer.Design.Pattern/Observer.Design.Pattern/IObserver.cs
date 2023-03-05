namespace Observer.Design.Pattern
{
    /// <summary>
    /// The 'subscriper' interface
    /// The Observer defines an updating interface for objects that should be notified of changes in a Subject.
    /// </summary>

    public interface IObserver
    {
        void update(string availability);
    }
}
