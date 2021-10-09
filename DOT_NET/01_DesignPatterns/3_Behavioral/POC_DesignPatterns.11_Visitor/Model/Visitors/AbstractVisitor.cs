namespace POC_DesignPatterns._11_Visitor.Model.Visitors
{
    using POC_DesignPatterns._11_Visitor.Model.Composites;
    using POC_DesignPatterns._11_Visitor.Model.Leaf;

    /// <summary>
    /// AbstractVisitor class.
    /// </summary>
    public abstract class AbstractVisitor
    {
        /// <summary>
        /// Visits the specified node.
        /// </summary>
        /// <param name="node">The node.</param>
        public abstract void Visit(ConcreteComposite1 node);

        /// <summary>
        /// Visits the specified node.
        /// </summary>
        /// <param name="node">The node.</param>
        public abstract void Visit(ConcreteComposite2 node);

        /// <summary>
        /// Visits the specified node.
        /// </summary>
        /// <param name="node">The node.</param>
        public abstract void Visit(ConcreteLeaf node);
    }
}