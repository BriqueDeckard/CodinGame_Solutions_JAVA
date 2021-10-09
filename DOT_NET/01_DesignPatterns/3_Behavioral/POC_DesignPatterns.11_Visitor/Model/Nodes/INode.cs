namespace POC_DesignPatterns._11_Visitor.Model.Nodes
{
    using POC_DesignPatterns._11_Visitor.Model.Visitors;

    /// <summary>
    /// INode interface for Node object.
    /// </summary>
    public interface INode
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        void AcceptVisitor(AbstractVisitor visitor);

        /// <summary>
        /// Adds the child.
        /// </summary>
        /// <param name="child">The child.</param>
        void AddChild(AbstractNode child);

        /// <summary>
        /// Operations this instance.
        /// </summary>
        void DoOperation();

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns></returns>
        string GetName();
    }
}