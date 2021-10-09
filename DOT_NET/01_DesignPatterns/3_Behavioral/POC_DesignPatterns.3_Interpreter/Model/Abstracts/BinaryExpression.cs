namespace POC_DesignPatterns._3_Interpreter.Abstracts
{
    /// <summary>
    /// Composite expression.
    /// </summary>
    /// <seealso cref="AbstractExpression" />
    public abstract class BinaryExpression : AbstractExpression
    {
        /// <summary>
        /// The expression1
        /// </summary>
        protected AbstractExpression Expression1;

        /// <summary>
        /// The expression2
        /// </summary>
        protected AbstractExpression Expression2;

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryExpression"/> class.
        /// </summary>
        /// <param name="expression1">The expression1.</param>
        /// <param name="expression2">The expression2.</param>
        protected BinaryExpression(AbstractExpression expression1, AbstractExpression expression2)
        {
            Expression1 = expression1;
            Expression2 = expression2;
        }
    }
}