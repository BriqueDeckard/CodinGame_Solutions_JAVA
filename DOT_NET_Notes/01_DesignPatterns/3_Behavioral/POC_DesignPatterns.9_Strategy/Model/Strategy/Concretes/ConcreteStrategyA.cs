namespace POC_DesignPatterns._9_Strategy.Model.Strategy.Concretes
{
    using POC_DesignPatterns._9_Strategy.Model.Strategy.Abstract;

    /// <summary>
    /// "ConcreteStrategyA" class.
    /// </summary>
    /// <seealso cref="AbstractStrategy" />
    public class ConcreteStrategyA : AbstractStrategy
    {
        /// <summary>
        /// Accesses the algorithm interface.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public override void AccessAlgorithmInterface()
        {
            Logger.Logger.Log(this.GetType().Name + " AccessAlgorithmInterface");
        }
    }
}