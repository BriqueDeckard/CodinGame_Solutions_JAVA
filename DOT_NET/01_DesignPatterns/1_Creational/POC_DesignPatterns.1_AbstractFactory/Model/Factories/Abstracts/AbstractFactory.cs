namespace POC_DesignPatterns._1_AbstractFactory.Factories.Abstracts
{
    using POC_DesignPatterns._1_AbstractFactory.Products.Abstracts;

    /// <summary>
    /// "AbstractFactory" class.
    /// </summary>
    public abstract class AbstractFactory
    {
        /// <summary>
        /// Creates the abstract product A.
        /// </summary>
        /// <returns></returns>
        public abstract AbstractProductA CreateProductA();

        /// <summary>
        /// Creates the abstract product B.
        /// </summary>
        /// <returns></returns>
        public abstract AbstractProductB CreateProductB();
    }
}