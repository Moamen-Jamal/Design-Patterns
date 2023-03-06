namespace Command.After
{
    /// <summary>
    /// The 'Command' interface
    /// The Command interface defines the common methods like Execute, Undo for all commands. 
    /// </summary>
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
