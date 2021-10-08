namespace POC_DesignPatterns._3_Interpreter.Contracts
{
    /// <summary>
    /// IExpression interface.
    /// </summary>
    public interface IExpression
    {
        /// <summary>
        /// Interprets this instance.
        /// </summary>
        /// <returns></returns>
        int Interpret();
    }
}