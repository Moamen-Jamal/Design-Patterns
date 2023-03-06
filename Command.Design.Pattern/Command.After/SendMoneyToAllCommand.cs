namespace Command.After
{
    /// <summary>
    /// The 'Command' class
    /// implement all the methods of the Command interface. 
    /// command can accept one or several receiver objects along
    /// with any context data via the constructor
    /// </summary>
    public class SendMoneyToAllCommand : ICommand
    {
        private List<Receiver> receivers { get; set; }
        public SendMoneyToAllCommand(List<Receiver> receivers)
        {
            this.receivers = receivers;
        }
        public void Execute()
        {
            foreach (var receiver in receivers)
            {
                receiver.SendMoney(500);
            };
        }

        public void Undo()
        {
            foreach (var receiver in receivers)
            {
                receiver.SendMoney(-500);
            };
        }
    }
}
