namespace POC_DesignPatterns._1_AbstractFactory.Factories.Concretes
{
    using POC_DesignPatterns._1_AbstractFactory.Factories.Abstracts;

    using POC_DesignPatterns._1_AbstractFactory.Products.Abstracts;

    /// <summary>
    /// ConcreteFactory1 class.
    /// </summary>
    /// <seealso cref="AbstractFactory" />
    public class ConcreteFactory1 : AbstractFactory
    {
        /// <summary>
        /// Creates the concrete product A.
        /// </summary>
        /// <returns></returns>
        public override AbstractProductA CreateProductA()
        {
            Logger.Logger.Log(TAG + "CreateProductA");
            return new ConcreteProductA1();
        }

        /// <summary>
        /// Creates the concrete product B.
        /// </summary>
        /// <returns></returns>
        public override AbstractProductB CreateProductB()
        {
            Logger.Logger.Log(TAG + "CreateProductB");
            return new ConcreteProductB1();
        }

        /// <summary>
        /// The tag
        /// </summary>
        private const string TAG = "ConcreteFactory1 ";
    }
}