namespace POC_DesignPatterns._3_Interpreter.Concretes.Operators
{
    using _3_Interpreter.Abstracts;

    using System;

    /// <summary>
    /// Multiplier class.
    /// </summary>
    /// <seealso cref="BinaryExpression" />
    public class MultiplierOperator : BinaryExpression
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiplierOperator"/> class.
        /// </summary>
        /// <param name="expression1">The expression1.</param>
        /// <param name="expression2">The expression2.</param>
        public MultiplierOperator(AbstractExpression expression1, AbstractExpression expression2)
            : base(expression1, expression2)
        {
        }

        /// <summary>
        /// Interprets this instance.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public override int Interpret()
        {
            if ((Expression1 == null) || (Expression2 == null))
            {
                throw new ArgumentNullException();
            }
            return Expression1.Interpret() * Expression2.Interpret();
        }
    }
}