namespace POC_DesignPatterns._4_Iterator.Contracts
{
    /// <summary>
    /// Interface for aggregate.
    /// </summary>
    public interface IAggregate
    {
        /// <summary>
        /// Gets the iterator.
        /// </summary>
        /// <returns></returns>
        IIterator GetIterator();
    }
}