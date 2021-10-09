namespace POC_DesignPatterns._4_Decorator.Abstract
{
    /// <summary>
    /// AbstractDecorator class.
    /// </summary>
    /// <seealso cref="AbstractComponent" />
    public abstract class AbstractDecorator : AbstractComponent
    {
        /// <summary>
        /// The component
        /// </summary>
        public AbstractComponent Component;

        /// <summary>
        /// Operations this instance.
        /// </summary>
        public override void Operation()
        {
            Component?.Operation();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractDecorator"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        protected AbstractDecorator(AbstractComponent component)
        {
            Component = component;
        }
    }
}