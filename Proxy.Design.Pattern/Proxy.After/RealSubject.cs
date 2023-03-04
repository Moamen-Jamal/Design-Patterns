namespace Proxy.After
{
    /// <summary>
    /// A 'RealSubject' class
    /// This is a class that we want to use more efficiently by using the proxy class.
    /// </summary>
    class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}
