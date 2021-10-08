namespace POC_DesignPatterns._2_Builder.Builder
{
    using POC_DesignPatterns._2_Builder.Model;

    /// <summary>
    /// Builder class.
    /// </summary>
    public class AbstractBuilder
    {
        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        /// <value>
        /// The product.
        /// </value>
        public Product Product
        {
            get
            {
                if (this._product == null)
                {
                    this._product = new Product();
                }
                return this._product;
            }
            set => _product = value;
        }

        /// <summary>
        /// Builds the part.
        /// </summary>
        public virtual void BuildPart()
        {
            this.Product.Body += "_Builder_\n\t";
        }

        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <returns></returns>
        public Product GetResult()
        {
            return this.Product;
        }

        /// <summary>
        /// The product
        /// </summary>
        private Product _product;
    }
}