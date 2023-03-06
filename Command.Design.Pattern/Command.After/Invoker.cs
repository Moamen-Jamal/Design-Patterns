namespace Command.After
{
    /// <summary>
    /// The 'Invoker' class
    /// The Invoker is associated with one or several commands. It sends a request to the command.
    /// </summary>
    public class Invoker
    {
        public void Execute(ICommand command)
        {
            command.Execute();
        }

        public void Undo(ICommand command)
        {
            command.Undo();
        }
    }
}
