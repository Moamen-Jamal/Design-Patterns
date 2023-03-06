namespace Command.Before
{
    public class Sender
    {
        private Receiver? receiver { get; set; }
        private List<Receiver>? receivers { get; set; }

        public Sender(Receiver? receiver)
        {
            this.receiver = receiver;
        }
        public Sender(List<Receiver>? receivers)
        {
            this.receivers = receivers;
        }

        public void Execute()
        {
            if(receivers == null || receivers?.Count == 0)
            {
                receiver?.SendMoney(500);
            }
            else
            {
                foreach (var receiver in receivers)
                {
                    receiver.SendMoney(500);
                };
            }

        }

        public void Undo()
        {
            if (receivers == null || receivers?.Count == 0)
            {
                receiver.SendMoney(-500);
            }
            else
            {
                foreach (var receiver in receivers)
                {
                    receiver.SendMoney(-500);
                };
            }
        }
    }
}
