namespace POC_DesignPatterns._1_ChainOfResponsability.Handler
{
    /// <summary>
    /// ConcreteHandler3 class.
    /// </summary>
    /// <seealso cref="AbstractHandler" />
    public class ConcreteHandler3 : AbstractHandler
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteHandler3"/> class.
        /// </summary>
        public ConcreteHandler3()
        {
            Allowable = 300;
        }
    }
}