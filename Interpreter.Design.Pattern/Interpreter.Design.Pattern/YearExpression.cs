namespace Interpreter.Design.Pattern
{
    /// <summary>
    /// The TerminalExpression class
    /// implements an Interpret operation associated with Date Format "Year".
    /// </summary>
    public class YearExpression : AbstractExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.expression;
            context.expression = expression.Replace("YYYY", context.date.Year.ToString());
        }
    }
}
