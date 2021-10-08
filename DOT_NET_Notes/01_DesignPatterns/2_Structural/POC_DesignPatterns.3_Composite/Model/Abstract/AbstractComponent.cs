namespace POC_DesignPatterns._3_Composite.Abstract
{
    using System.Collections.Generic;

    /// <summary>
    /// AbstractComponent class.
    /// </summary>
    public abstract class AbstractComponent
    {
        /// <summary>
        /// Adds the specified component.
        /// </summary>
        /// <param name="component">The component.</param>
        public void Add(AbstractComponent component)
        {
            this._children.Add(component);
        }

        /// <summary>
        /// Gets the child.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <returns></returns>
        public AbstractComponent GetChild(int i)
        {
            return (AbstractComponent)this._children.ToArray().GetValue(i);
        }

        /// <summary>
        /// Gets the children.
        /// </summary>
        /// <returns></returns>
        public IList<AbstractComponent> GetChildren()
        {
            return _children;
        }

        /// <summary>
        /// Operations this instance.
        /// </summary>
        public abstract void Operation();

        /// <summary>
        /// Removes the specified component.
        /// </summary>
        /// <param name="component">The component.</param>
        public void Remove(AbstractComponent component)
        {
            this._children.Remove(component);
        }

        /// <summary>
        /// The children
        /// </summary>
        private readonly List<AbstractComponent> _children = new List<AbstractComponent>();
    }
}