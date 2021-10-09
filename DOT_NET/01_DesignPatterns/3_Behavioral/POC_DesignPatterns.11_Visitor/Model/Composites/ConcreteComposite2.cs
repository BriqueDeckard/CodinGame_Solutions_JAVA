namespace POC_DesignPatterns._11_Visitor.Model.Composites
{
    using POC_DesignPatterns._11_Visitor.Model.Nodes;
    using POC_DesignPatterns._11_Visitor.Model.Visitors;

    /// <summary>
    /// ConcreteComposite2 class.
    /// </summary>
    /// <seealso cref="POC_DesignPatterns._11_Visitor.Model.Composites.AbstractComposite" />
    public class ConcreteComposite2 : AbstractComposite
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteComposite2"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public ConcreteComposite2(string name) : base(name)
        {
        }

        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public override void AcceptVisitor(AbstractVisitor visitor)
        {
            visitor.Visit(this);
            foreach (AbstractNode abstractNode in Children)
            {
                abstractNode.AcceptVisitor(visitor);
            }
        }
    }
}