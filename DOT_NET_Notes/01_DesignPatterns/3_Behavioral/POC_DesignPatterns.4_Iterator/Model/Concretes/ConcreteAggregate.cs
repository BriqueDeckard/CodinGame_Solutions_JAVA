namespace POC_DesignPatterns._4_Iterator.Concretes
{
    using POC_DesignPatterns._4_Iterator.Contracts;

    using System;

    /// <summary>
    /// ConcreteAggregate class.
    /// </summary>
    /// <seealso cref="IAggregate" />
    public class ConcreteAggregate : IAggregate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteAggregate"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public ConcreteAggregate(object[] data)
        {
            this._data = data;
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public object[] Data { get => _data; set => _data = value; }

        /// <summary>
        /// Gets the iterator.
        /// </summary>
        /// <returns></returns>
        public IIterator GetIterator()
        {
            return new ConcreteIterator(this);
        }

        /// <summary>
        /// The data
        /// </summary>
        private Object[] _data;
    }
}