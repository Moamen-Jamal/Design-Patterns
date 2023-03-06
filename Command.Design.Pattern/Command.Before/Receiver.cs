namespace Command.Before
{
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
