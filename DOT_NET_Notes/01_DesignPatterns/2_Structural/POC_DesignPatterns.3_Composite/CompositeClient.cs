namespace POC_DesignPatterns._3_Composite
{
    using POC_DesignPatterns._3_Composite.Abstract;
    using POC_DesignPatterns._3_Composite.Concretes;

    using System;

    /// <summary>
    /// CompositeClient class.
    /// </summary>
    public class CompositeClient
    {
        /// <summary>
        /// Demoes this instance.
        /// </summary>
        public void Demo()
        {
            AbstractComponent composite1 = new Composite();
            AbstractComponent composite2 = new Composite();
            AbstractComponent composite3 = new Composite();
            AbstractComponent composite4 = new Composite();
            AbstractComponent leaf = new Leaf();

            composite4.Add(leaf);
            composite3.Add(composite4);
            composite2.Add(composite3);
            composite1.Add(composite2);

            composite1.Operation();
            Console.ReadLine();
        }
    }
}