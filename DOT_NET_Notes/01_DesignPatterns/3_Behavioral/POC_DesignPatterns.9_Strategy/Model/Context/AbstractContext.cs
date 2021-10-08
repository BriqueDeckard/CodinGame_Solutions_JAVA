namespace POC_DesignPatterns._9_Strategy.Model.Context
{
    using POC_DesignPatterns._9_Strategy.Model.Strategy.Abstract;

    /// <summary>
    /// AbstractContext class.
    /// </summary>
    public class AbstractContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractContext" /> class.
        /// </summary>
        /// <param name="strategy">The strategy.</param>
        public AbstractContext(AbstractStrategy strategy)
        {
            _strategy = strategy;
        }

        /// <summary>
        /// Gets or sets the strategy.
        /// </summary>
        /// <value>
        /// The strategy.
        /// </value>
        public AbstractStrategy Strategy
        {
            get => _strategy;
            set => _strategy = value;
        }

        /// <summary>
        /// Contexts the interface.
        /// </summary>
        public void ContextInterface()
        {
            _strategy.AccessAlgorithmInterface();
        }

        /// <summary>
        /// The strategy
        /// </summary>
        private AbstractStrategy _strategy;
    }
}