namespace Proxy.After
{
    /// <summary>
    /// A 'Subject' interface
    /// This is an interface that defines members that are going to be implemented by the RealSubject and Proxy class so that the Proxy can be used anywhere the RealSubject is expected.
    /// </summary>
    public interface ISubject
    {
        void Request();
    }
}
