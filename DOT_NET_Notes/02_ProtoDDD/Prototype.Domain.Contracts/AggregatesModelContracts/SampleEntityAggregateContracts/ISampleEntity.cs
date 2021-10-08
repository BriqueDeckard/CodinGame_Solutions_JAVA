using Prototype.Domain.Contracts.SeedWork;

namespace Prototype.Domain.Contracts.AggregatesModelContracts.SampleEntityAggregateContracts
{
    /// <summary>
    ///     Interface for one of the domain entities
    /// </summary>
    public interface ISampleEntity : IAggregateRoot
    {
        #region Methods : Entity's behavior and logic.

        /// <summary>
        ///     Manipulates the string attribute.
        /// </summary>
        public void SomeStringManipulation(string text);

        #endregion

        #region Attributes : Entity's data.

        /// <summary>
        ///     Gets or sets the string attribute.
        /// </summary>
        public string StringValue { get; }

        /// <summary>
        ///     Gets or sets the price value.
        /// </summary>
        /// <value>
        ///     The price value.
        /// </value>
        public double PriceValue { get; set; }

        #endregion
    }
}