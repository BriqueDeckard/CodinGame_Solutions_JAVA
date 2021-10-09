namespace POC_DesignPatterns._3_FactoryMethod
{
    using System;

    /// <summary>
    /// FactoryMethodClient class.
    /// </summary>
    public class FactoryMethodClient
    {
        /// <summary>
        /// Demoes this instance.
        /// </summary>
        public void Demo()
        {
            AbstractCreator creator = new ConcreteCreator();
            AbstractProduct product = creator.Product;
            Logger.Logger.Log(product.GetType().FullName);
            Console.ReadLine();
        }
    }
}