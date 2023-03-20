namespace Interpreter.Design.Pattern
{
    /// <summary>
    /// The Context Class
    /// contains information that is global to the interpreter.
    /// </summary>
    public class Context
    {
        public string expression { get; set; }
        public DateTime date { get; set; }
        public Context(DateTime date)
        {
            this.date = date;
        }
    }
}
