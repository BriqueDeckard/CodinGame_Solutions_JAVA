namespace POC_DesignPatterns._4_Decorator
{
    using _4_Decorator.Abstract;
    using _4_Decorator.Concretes;

    using System;

    /// <summary>
    /// DecoratorClient class.
    /// </summary>
    public class DecoratorClient
    {
        /// <summary>
        /// Demo.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Demo()
        {
            ConcreteComponent concreteComponent = new ConcreteComponent();

            AbstractComponent a = new ConcreteDecoratorB(new ConcreteDecoratorA(concreteComponent));

            a.Operation();
            Console.ReadLine();
        }
    }
}