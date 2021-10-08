namespace POC_DesignPatterns._3_FactoryMethod
{
    /// <summary>
    /// Abstract Creator class.
    /// </summary>
    public abstract class AbstractCreator
    {
        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        /// <value>
        /// The product.
        /// </value>
        public AbstractProduct Product
        {
            get
            {
                AnOperation();
                return this._product;
            }
            set => this._product = value;
        }

        /// <summary>
        /// Ans the operation.
        /// </summary>
        public void AnOperation()
        {
            Logger.Logger.Log("AbstractCreator AnOperation");
            this.Product = FactoryMethod();
        }

        /// <summary>
        /// Factories the method.
        /// </summary>
        /// <returns></returns>
        public abstract AbstractProduct FactoryMethod();

        /// <summary>
        /// The product
        /// </summary>
        private AbstractProduct _product;
    }
}