namespace POC_DesignPatterns._10_TemplateMethod
{
    using POC_DesignPatterns._10_TemplateMethod.Model;

    using System;

    /// <summary>
    /// Template method client.
    /// </summary>
    public class TemplateMethodClient
    {
        /// <summary>
        /// Demoes this instance.
        /// </summary>
        public void Demo()
        {
            AbstractClass demoClass = new ConcreteClass();
            demoClass.TemplateMethod();
            Console.ReadLine();
        }
    }
}