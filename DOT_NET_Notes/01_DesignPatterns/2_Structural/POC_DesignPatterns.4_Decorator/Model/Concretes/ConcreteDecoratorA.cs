namespace POC_DesignPatterns._4_Decorator.Concretes
{
    using _4_Decorator.Abstract;

    /// <summary>
    /// ConcreteDecoratorA class.
    /// </summary>
    /// <seealso cref="AbstractDecorator" />
    public class ConcreteDecoratorA : AbstractDecorator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteDecoratorA"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        public ConcreteDecoratorA(AbstractComponent component) : base(component)
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
            Logger.Logger.Log("-AddedBehaviour A");
        }
    }
}