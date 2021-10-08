namespace POC_DesignPatterns._2_Builder.Builder
{
    /// <summary>
    /// ConcreteBuilderA class.
    /// </summary>
    /// <seealso cref="AbstractBuilder" />
    public class ConcreteBuilderA : AbstractBuilder
    {
        /// <summary>
        /// Builds the part.
        /// </summary>
        public override void BuildPart()
        {
            base.BuildPart();
            this.Product.Body += "_ConcreteBuilderA_\n\t";
        }
    }
}