namespace POC_DesignPatterns._3_Interpreter.Tools
{
    using _3_Interpreter.Concretes.Operators;

    using POC_DesignPatterns._3_Interpreter.Abstracts;
    using POC_DesignPatterns._3_Interpreter.Concretes;

    using System;
    using System.Data;

    /// <summary>
    /// Parser class.
    /// </summary>
    public abstract class Parser
    {
        /// <summary>
        /// Parses the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        /// <exception cref="InvalidExpressionException"></exception>
        public static AbstractExpression parse(string expression)
        {
            string[] parts = expression.Split(" ");
            if (parts.Length != 3)
            {
                throw new ArgumentOutOfRangeException();
            }

            AbstractExpression expression1 = new Number(parts[0]);
            AbstractExpression expression2 = new Number(parts[2]);

            AbstractExpression operation = null;
            switch (parts[1])
            {
                case "times": operation = new MultiplierOperator(expression1, expression2); break;
                case "plus": operation = new AdderOperator(expression1, expression2); break;
                case "minus": operation = new SubstractorOperator(expression1, expression2); break;
                case "divided by": operation = new DivisorOperator(expression1, expression2); break;
                default: throw new InvalidExpressionException(expression);
            }

            return operation;
        }
    }
}