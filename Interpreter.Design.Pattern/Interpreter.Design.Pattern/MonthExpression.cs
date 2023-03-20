namespace Interpreter.Design.Pattern
{
    /// <summary>
    /// The TerminalExpression class
    /// implements an Interpret operation associated with Date Format "Month".
    /// </summary>
    public class MonthExpression : AbstractExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.expression;
            context.expression = expression.Replace("MM", context.date.Month.ToString());
        }
    }
}
