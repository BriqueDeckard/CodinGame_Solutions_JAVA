namespace POC_DesignPatterns._4_Iterator.Concretes
{
    using _4_Iterator.Contracts;

    using System;

    /// <summary>
    /// Concrete iterator class.
    /// </summary>
    /// <seealso cref="IIterator" />
    public class ConcreteIterator : IIterator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteIterator"/> class.
        /// </summary>
        /// <param name="concreteAggregate">The concrete aggregate.</param>
        public ConcreteIterator(ConcreteAggregate concreteAggregate)
        {
            _concreteAggregate = concreteAggregate;
            this._index = -1;
        }

        /// <summary>
        /// Gets the next.
        /// </summary>
        /// <returns></returns>
        public object GetNext()
        {
            this._index++;
            return _concreteAggregate.Data[this._index];
        }

        /// <summary>
        /// Determines whether this instance has next.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance has next; otherwise, <c>false</c>.
        /// </returns>
        public bool HasNext()
        {
            Console.WriteLine();
            return this._index < this._concreteAggregate.Data.Length - 1;
        }

        /// <summary>
        /// The concrete aggregate
        /// </summary>
        private ConcreteAggregate _concreteAggregate;

        /// <summary>
        /// The index
        /// </summary>
        private int _index;
    }
}