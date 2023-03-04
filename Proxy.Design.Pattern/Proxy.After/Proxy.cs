namespace Proxy.After
{
    /// <summary>
    /// A 'Proxy' class
    /// This is a class that holds a reference to the RealSubject class and can access RealSubjecr class members as required. 
    /// It must implement the same interface as the RealSubject so that the two can be used interchangeably.
    /// </summary>
    class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            this._realSubject = realSubject;
        }
        public void Request()
        {
            if (this.CheckAccess())
            {
                this._realSubject.Request();

                this.LogAccess();
            }
        }
        public bool CheckAccess()
        {
            // Some real checks should go here.
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");

            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }
}
