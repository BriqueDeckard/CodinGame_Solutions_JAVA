namespace POC_DesignPatterns._10_TemplateMethod.Model
{
    /// <summary>
    /// AbstractClass class.
    /// </summary>
    public abstract class AbstractClass
    {
        /// <summary>
        /// Templates the method.
        /// </summary>
        public void TemplateMethod()
        {
            DoPrimitiveOperation1();
            DoPrimitiveOperation2();
            DoPrimitiveOperation3();
            DoPrimitiveOperation4();
        }

        /// <summary>
        /// Does the primitive operation1.
        /// </summary>
        protected abstract void DoPrimitiveOperation1();

        /// <summary>
        /// Does the primitive operation2.
        /// </summary>
        protected abstract void DoPrimitiveOperation2();

        /// <summary>
        /// Does the primitive operation3.
        /// </summary>
        protected abstract void DoPrimitiveOperation3();

        /// <summary>
        /// Does the primitive operation4.
        /// </summary>
        protected abstract void DoPrimitiveOperation4();
    }
}