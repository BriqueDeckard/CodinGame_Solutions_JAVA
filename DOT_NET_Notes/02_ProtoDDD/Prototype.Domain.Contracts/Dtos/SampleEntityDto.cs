namespace Prototype.Domain.Contracts.Dtos
{
    /// <summary>
    ///     Dto to transmit data between layers
    /// </summary>
    public class SampleEntityDto
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SampleEntityDto" /> class.
        /// </summary>
        /// <param name="stringValue">The string value.</param>
        /// <param name="priceValue">The price value.</param>
        /// <param name="id">The identifier.</param>
        public SampleEntityDto(string stringValue, double priceValue, int? id)
        {
            StringValue = stringValue;
            PriceValue = priceValue;
            Id = id;
        }

        #region Properties

        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>
        ///     The identifier.
        /// </value>
        public int? Id { get; set; }

        /// <summary>
        ///     Gets the string value.
        /// </summary>
        /// <value>
        ///     The string value.
        /// </value>
        public string StringValue { get; }

        /// <summary>
        ///     Gets the price value.
        /// </summary>
        /// <value>
        ///     The price value.
        /// </value>
        public double PriceValue { get; }

        #endregion

    }
}