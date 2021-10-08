namespace POC_DesignPatterns._11_Visitor.Model.Leaf
{
    using POC_DesignPatterns._11_Visitor.Model.Nodes;

    /// <summary>
    /// AbstractLeaf class.
    /// </summary>
    /// <seealso cref="AbstractNode" />
    public abstract class AbstractLeaf : AbstractNode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractLeaf"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        protected AbstractLeaf(string name) : base(name)
        {
        }
    }
}