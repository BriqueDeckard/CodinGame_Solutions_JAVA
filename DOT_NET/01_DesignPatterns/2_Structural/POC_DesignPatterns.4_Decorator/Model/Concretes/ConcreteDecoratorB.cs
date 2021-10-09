namespace POC_DesignPatterns._4_Decorator.Concretes
{
    using _4_Decorator.Abstract;

    /// <summary>
    /// ConcreteDecoratorB class.
    /// </summary>
    /// <seealso cref="AbstractDecorator" />
    public class ConcreteDecoratorB : AbstractDecorator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteDecoratorB"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        public ConcreteDecoratorB(AbstractComponent component) : base(component)
        {
        }

        /// <summary>
        /// Operations this instance.
        /// </summary>
        public override void Operation()
        {
            this.AddedBehaviour();
            base.Operation();
        }

        /// <summary>
        /// Added behaviour method.
        /// </summary>
        private void AddedBehaviour()
        {
            Logger.Logger.Log("--AddedBehaviour B ");
        }
    }
}