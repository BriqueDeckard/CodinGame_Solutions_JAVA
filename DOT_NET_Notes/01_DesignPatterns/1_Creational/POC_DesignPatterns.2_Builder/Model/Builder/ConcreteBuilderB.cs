namespace POC_DesignPatterns._2_Builder.Builder
{
    /// <summary>
    /// Concrete Builder B class.
    /// </summary>
    /// <seealso cref="AbstractBuilder" />
    public class ConcreteBuilderB : AbstractBuilder
    {
        /// <summary>
        /// Builds the part.
        /// </summary>
        public override void BuildPart()
        {
            base.BuildPart();
            this.Product.Body += "_ConcreteBuilderB_\n\t";
        }
    }
}