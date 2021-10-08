namespace POC_DesignPatterns._11_Visitor.Model.Visitors
{
    using POC_DesignPatterns._11_Visitor.Model.Composites;
    using POC_DesignPatterns._11_Visitor.Model.Leaf;

    /// <summary>
    /// ConcreteVisitor class.
    /// </summary>
    /// <seealso cref="AbstractVisitor" />
    public class ConcreteVisitor : AbstractVisitor
    {
        /// <summary>
        /// Visits the specified node.
        /// </summary>
        /// <param name="node">The node.</param>
        public override void Visit(ConcreteComposite1 node)
        {
            Logger.Logger.Log("Visit" + node.GetType().Name);
        }

        /// <summary>
        /// Visits the specified node.
        /// </summary>
        /// <param name="node">The node.</param>
        public override void Visit(ConcreteComposite2 node)
        {
            Logger.Logger.Log("Visit" + node.GetType().Name);
        }

        /// <summary>
        /// Visits the specified node.
        /// </summary>
        /// <param name="node">The node.</param>
        public override void Visit(ConcreteLeaf node)
        {
            Logger.Logger.Log("Visit" + node.GetType().Name);
        }
    }
}