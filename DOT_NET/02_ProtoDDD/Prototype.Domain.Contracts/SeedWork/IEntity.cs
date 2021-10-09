namespace Prototype.Domain.Contracts.SeedWork
{
    /// <summary>
    ///     Contract for entity
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>
        ///     The identifier.
        /// </value>
        public int Id { get; set; }
    }
}