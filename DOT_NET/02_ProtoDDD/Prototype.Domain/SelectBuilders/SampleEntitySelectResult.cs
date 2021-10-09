namespace Prototype.Domain.SelectBuilders
{
    /// <summary>
    ///     Results for the sample entity search
    /// </summary>
    public class SampleEntitySelectResult
    {
        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>
        ///     The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        ///     Gets or sets the string value.
        /// </summary>
        /// <value>
        ///     The string value.
        /// </value>
        public string StringValue { get; set; }

        /// <summary>
        ///     Gets or sets the price.
        /// </summary>
        /// <value>
        ///     The price.
        /// </value>
        public double Price { get; set; }
    }
}