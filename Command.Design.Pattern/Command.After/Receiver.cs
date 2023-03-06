namespace Command.After
{
    /// <summary>
    /// The 'Receiver' class
    /// It contains some important business logic. They know how
    /// to perform all kinds of operations, associated with carrying out a
    /// request. In fact, any class may serve as a Receiver. 
    /// </summary>
    public class Receiver
    {
        public Receiver(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        private int Money { get; set; }
        public void SendMoney(int money)
        {
            Money += money;
            Console.WriteLine($"Receiver with Id: {Id} and Total Money = {Money}");
        }
    }
}
