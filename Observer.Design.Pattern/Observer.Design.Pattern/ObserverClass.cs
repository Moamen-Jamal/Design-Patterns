namespace Observer.Design.Pattern
{
    /// <summary>
    /// The 'ConcreteObserver' (subscriper) class
    /// t maintains a reference to a ConcreteSubject object and implements the Observer interface to keep its state consistent with that of the Subjects.
    /// </summary>
    public class ObserverClass : IObserver
    {
        public string UserName { get; set; }
        public ObserverClass(string userName, ISubject subject)
        {
            UserName = userName;
            subject.RegisterObserver(this);
        }

        public void update(string availabiliy)
        {
            Console.WriteLine("Hello " + UserName + ", Product is now " + availabiliy + " on Our Site");
        }
    }
}
