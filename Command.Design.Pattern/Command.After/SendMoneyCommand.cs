namespace Command.After
{
    /// <summary>
    /// The 'Command' class
    /// implement all the methods of the Command interface. 
    /// command can accept one or several receiver objects along
    /// with any context data via the constructor
    /// </summary>
    public class SendMoneyCommand : ICommand
    {
        private Receiver receiver { get; set; }
        public SendMoneyCommand(Receiver receiver)
        {
            this.receiver = receiver;   
        }
        public void Execute()
        {
            receiver.SendMoney(500);
        }

        public void Undo()
        {
            receiver.SendMoney(-500);
        }
    }
}
