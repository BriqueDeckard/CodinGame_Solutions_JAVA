namespace POC_DesignPatterns._11_Visitor.Model.Nodes
{
    using POC_DesignPatterns._11_Visitor.Model.Visitors;

    /// <summary>
    /// AbstractNode class.
    /// </summary>
    /// <seealso cref="INode" />
    public abstract class AbstractNode : INode
    {
        /// <summary>
        /// Accepts the specified v.
        /// </summary>
        /// <param name="v">The v.</param>
        public abstract void AcceptVisitor(AbstractVisitor v);

        /// <summary>
        /// Adds the child.
        /// </summary>
        public virtual void AddChild(AbstractNode child) { }

        /// <summary>
        /// Operations this instance.
        /// </summary>
        public virtual void DoOperation()
        {
            Logger.Logger.Log(GetName());
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return this.Name;
        }

        /// <summary>
        /// The name
        /// </summary>
        protected string Name;

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractNode"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        protected AbstractNode(string name)
        {
            Name = name;
        }
    }
}