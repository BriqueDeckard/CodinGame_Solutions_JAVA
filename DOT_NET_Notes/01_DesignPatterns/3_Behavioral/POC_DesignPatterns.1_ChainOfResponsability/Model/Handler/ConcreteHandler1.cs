namespace POC_DesignPatterns._1_ChainOfResponsability.Handler
{
    /// <summary>
    /// ConcreteHandler1 class.
    /// </summary>
    /// <seealso cref="AbstractHandler" />
    public class ConcreteHandler1 : AbstractHandler
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteHandler1"/> class.
        /// </summary>
        /// <param name="successor">The successor.</param>
        /// <param name="allowable"></param>
        public ConcreteHandler1()
        {
            Allowable = 100;
        }
    }
}