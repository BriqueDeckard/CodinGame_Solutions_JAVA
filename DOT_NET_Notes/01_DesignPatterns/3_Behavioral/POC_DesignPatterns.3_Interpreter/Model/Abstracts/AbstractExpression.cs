using POC_DesignPatterns._3_Interpreter.Contracts;

namespace POC_DesignPatterns._3_Interpreter.Abstracts
{
    /// <summary>
    /// AbstractExpression class.
    /// </summary>
    /// <seealso cref="POC_DesignPatterns._3_Interpreter.Contracts.IExpression" />
    public abstract class AbstractExpression : IExpression
    {
        /// <summary>
        /// Interprets this instance.
        /// </summary>
        /// <returns></returns>
        public abstract int Interpret();
    }
}