namespace POC_DesignPatterns._9_Strategy
{
    using POC_DesignPatterns._9_Strategy.Model.Context;
    using POC_DesignPatterns._9_Strategy.Model.Strategy.Abstract;
    using POC_DesignPatterns._9_Strategy.Model.Strategy.Concretes;

    using System;

    /// <summary>
    /// StrategyClient class.
    /// </summary>
    public class StrategyClient
    {
        /// <summary>
        /// Demoes this instance.
        /// </summary>
        public void Demo()
        {
            AbstractContext context;
            context = new ConcreteContext(new ConcreteStrategyA());
            context.ContextInterface();
            AbstractStrategy strategyB = new ConcreteStrategyB();
            context.Strategy = strategyB;
            context.ContextInterface();
            AbstractStrategy strategyC = new ConcreteStrategyC();
            context.Strategy = strategyC;
            context.ContextInterface();

            Console.ReadLine();
        }
    }
}