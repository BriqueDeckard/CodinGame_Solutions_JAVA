namespace POC_DesignPatterns._10_TemplateMethod.Model
{
    /// <summary>
    /// ConcreteClass class.
    /// </summary>
    /// <seealso cref="AbstractClass" />
    public class ConcreteClass : AbstractClass
    {
        protected override void DoPrimitiveOperation1()
        {
            Logger.Logger.Log(this.GetType().Name + " DoPrimitiveOperation1");
        }

        /// <summary>
        /// Primitives the operation2.
        /// </summary>
        protected override void DoPrimitiveOperation2()
        {
            Logger.Logger.Log(this.GetType().Name + " DoPrimitiveOperation2");
        }

        /// <summary>
        /// Primitives the operation3.
        /// </summary>
        protected override void DoPrimitiveOperation3()
        {
            Logger.Logger.Log(this.GetType().Name + " DoPrimitiveOperation3");
        }

        /// <summary>
        /// Primitives the operation4.
        /// </summary>
        protected override void DoPrimitiveOperation4()
        {
            Logger.Logger.Log(this.GetType().Name + " DoPrimitiveOperation4");
        }
    }
}