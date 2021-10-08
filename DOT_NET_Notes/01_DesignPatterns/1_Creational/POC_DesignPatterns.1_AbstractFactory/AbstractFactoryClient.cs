namespace POC_DesignPatterns._1_AbstractFactory
{
    using POC_DesignPatterns._1_AbstractFactory.Factories.Abstracts;
    using POC_DesignPatterns._1_AbstractFactory.Factories.Concretes;
    using POC_DesignPatterns._1_AbstractFactory.Products.Abstracts;

    using System;
    using System.Collections.Generic;

    /// <summary>
    /// "Demo" class.
    /// </summary>
    public class AbstractFactoryClient
    {
        /// <summary>
        /// Demo this instance.
        /// </summary>
        public void Demo()
        {
            AbstractFactory factory = new ConcreteFactory1();
            AbstractProductA productA1 = factory.CreateProductA();
            AbstractProductB productB1 = factory.CreateProductB();

            factory = new ConcreteFactory2();
            AbstractProductA productA2 = factory.CreateProductA();
            AbstractProductB productB2 = factory.CreateProductB();

            List<Object> products = new List<object>();
            products.Add(productA1);
            products.Add(productA2);
            products.Add(productB1);
            products.Add(productB2);

            foreach (object o in products)
            {
                Logger.Logger.Log(o.ToString());
            }

            Console.ReadLine();
        }
    }
}