namespace POC_DesignPatterns._1_AbstractFactory.Factories.Concretes
{
    using POC_DesignPatterns._1_AbstractFactory.Factories.Abstracts;

    using POC_DesignPatterns._1_AbstractFactory.Products.Abstracts;

    /// <summary>
    /// "ConcreteFactory2" class.
    /// </summary>
    /// <seealso cref="AbstractFactory" />
    public class ConcreteFactory2 : AbstractFactory
    {
        /// <summary>
        /// Creates the product a.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public override AbstractProductA CreateProductA()
        {
            Logger.Logger.Log(TAG + "CreateProductA");
            return new ConcreteProductA2();
        }

        /// <summary>
        /// Creates the abstract product b.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public override AbstractProductB CreateProductB()
        {
            Logger.Logger.Log(TAG + "CreateProductB");
            return new ConcreteProductB2();
        }

        /// <summary>
        /// The tag
        /// </summary>
        private const string TAG = "ConcreteFactory2 ";
    }
}