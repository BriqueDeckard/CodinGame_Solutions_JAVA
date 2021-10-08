namespace POC_DesignPatterns._3_Interpreter
{
    using _3_Interpreter.Tools;

    using POC_DesignPatterns._3_Interpreter.Abstracts;

    using System;
    using System.Data;

    /// <summary>
    /// Interpreter client class.
    /// </summary>
    public class InterpreterClient
    {
        /// <summary>
        /// Demo.
        /// </summary>
        public void Demo()
        {
            string stringToParse = "nine plus one";
            try
            {
                // Parse the string into an interpretable expression.
                AbstractExpression parsedExpression = Parser.parse(stringToParse);
                // Interpret.
                Console.WriteLine(stringToParse + " = " + parsedExpression.Interpret());
            }
            catch (InvalidExpressionException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}