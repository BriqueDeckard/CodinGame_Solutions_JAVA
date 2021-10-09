namespace POC_DesignPatterns._4_Iterator
{
    using POC_DesignPatterns._4_Iterator.Concretes;
    using POC_DesignPatterns._4_Iterator.Contracts;

    using System;

    /// <summary>
    /// IteratorClient class.
    /// </summary>
    public class IteratorClient
    {
        /// <summary>
        /// Demoes this instance.
        /// </summary>
        public void Demo()
        {
            IAggregate aggregate = new ConcreteAggregate(new string[]
            {
                "Objet 1 ",
                "Objet 2 ",
                "Objet 3 ",
                "Objet 4 ",
                "Objet 5 ",
                "Objet 6 ",
                "Objet 7 ",
                "Objet 8 ",
                "Objet 9 ",
                "Objet 10 ",
            });

            IIterator iterator = aggregate.GetIterator();

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.GetNext());
            }

            Console.ReadLine();
        }
    }
}