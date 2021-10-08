namespace POC_DesignPatterns._1_ChainOfResponsability.Handler
{
    /// <summary>
    /// ConcreteHandler2 class.
    /// </summary>
    /// <seealso cref="AbstractHandler" />
    public class ConcreteHandler2 : AbstractHandler
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteHandler2"/> class.
        /// </summary>
        /// <param name="successor">The successor.</param>
        /// <param name="allowable"></param>
        public ConcreteHandler2()
        {
            Allowable = 200;
        }
    }
}