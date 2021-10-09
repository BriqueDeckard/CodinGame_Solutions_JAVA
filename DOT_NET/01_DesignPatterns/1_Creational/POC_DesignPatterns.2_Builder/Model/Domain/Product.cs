namespace POC_DesignPatterns._2_Builder.Model
{
    /// <summary>
    /// Product class.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        /// <value>
        /// The body.
        /// </value>
        public string Body { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return this.GetType().FullName + "body " + this.Body;
        }
    }
}