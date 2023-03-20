namespace Interpreter.Design.Pattern
{
    /// <summary>
    /// The AbstractExpression interface
    /// declares an interface for executing an operation.
    /// </summary>
    public interface AbstractExpression
    {
        void Evaluate(Context context);
    }
}
