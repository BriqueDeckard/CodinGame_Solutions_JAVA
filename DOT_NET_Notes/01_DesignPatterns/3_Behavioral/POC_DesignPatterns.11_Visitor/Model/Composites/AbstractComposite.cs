namespace POC_DesignPatterns._11_Visitor.Model.Composites
{
    using POC_DesignPatterns._11_Visitor.Model.Nodes;

    using System.Collections.Generic;

    /// <summary>
    /// AbstractComposite class.
    /// </summary>
    /// <seealso cref="AbstractNode" />
    public abstract class AbstractComposite : AbstractNode
    {
        /// <summary>
        /// Adds the child.
        /// </summary>
        /// <param name="child"></param>
        public override void AddChild(AbstractNode child)
        {
            this.Children.Add(child);
        }

        /// <summary>
        /// Operations this instance.
        /// </summary>
        public override void DoOperation()
        {
            base.DoOperation();
            foreach (AbstractNode abstractNode in Children)
            {
                abstractNode.DoOperation();
            }
        }

        /// <summary>
        /// The children
        /// </summary>
        protected List<AbstractNode> Children = new List<AbstractNode>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractComposite"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        protected AbstractComposite(string name) : base(name)
        {
        }
    }
}