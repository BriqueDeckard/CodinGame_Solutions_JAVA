namespace POC_DesignPatterns._11_Visitor.Model.Composites
{
    using POC_DesignPatterns._11_Visitor.Model.Nodes;
    using POC_DesignPatterns._11_Visitor.Model.Visitors;

    /// <summary>
    /// ConcreteComposite1 class.
    /// </summary>
    /// <seealso cref="AbstractComposite" />
    public class ConcreteComposite1 : AbstractComposite
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteComposite1"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public ConcreteComposite1(string name) : base(name)
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