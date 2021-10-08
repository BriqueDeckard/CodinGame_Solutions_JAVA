namespace POC_DesignPatterns._3_Composite.Concretes
{
    using POC_DesignPatterns._3_Composite.Abstract;

    /// <summary>
    /// Composite class.
    /// </summary>
    /// <seealso cref="AbstractComponent" />
    public class Composite : AbstractComponent
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        public override void Operation()
        {
            Logger.Logger.Log("Composite operation");
            foreach (AbstractComponent child in this.GetChildren())
            {
                child.Operation();
            }
        }
    }
}