namespace POC_DesignPatterns._9_Strategy.Model.Context
{
    using POC_DesignPatterns._9_Strategy.Model.Strategy.Abstract;

    /// <summary>
    /// ConcreteContext class.
    /// </summary>
    /// <seealso cref="POC_DesignPatterns._9_Strategy.Model.Context.AbstractContext" />
    internal class ConcreteContext : AbstractContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteContext"/> class.
        /// </summary>
        /// <param name="strategy">The strategy.</param>
        public ConcreteContext(AbstractStrategy strategy) : base(strategy)
        {
        }
    }
}