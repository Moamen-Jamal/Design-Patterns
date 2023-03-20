namespace Interpreter.Design.Pattern
{
    /// <summary>
    /// The TerminalExpression class
    /// implements an Interpret operation associated with Date Format "Day".
    /// </summary>
    public class DayExpression : AbstractExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.expression;
            context.expression = expression.Replace("DD", context.date.Day.ToString());
        }
    }
}
