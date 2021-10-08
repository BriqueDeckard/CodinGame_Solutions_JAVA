namespace POC_DesignPatterns._11_Visitor.Model.Leaf
{
    using POC_DesignPatterns._11_Visitor.Model.Visitors;

    /// <summary>
    /// ConcreteLeaf class.
    /// </summary>
    /// <seealso cref="AbstractLeaf" />
    public class ConcreteLeaf : AbstractLeaf
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteLeaf"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public ConcreteLeaf(string name) : base(name)
        {
        }

        /// <summary>
        /// Accepts the specified v.
        /// </summary>
        /// <param name="v">The v.</param>
        public override void AcceptVisitor(AbstractVisitor v)
        {
            v.Visit(this);
        }
    }
}