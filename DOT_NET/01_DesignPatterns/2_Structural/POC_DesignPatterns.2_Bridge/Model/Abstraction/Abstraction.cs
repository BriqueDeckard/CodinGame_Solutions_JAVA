namespace POC_DesignPatterns._2_Bridge.Abstraction
{
    using POC_DesignPatterns._2_Bridge.Implementor;

    using System;

    /// <summary>
    /// Abstraction class.
    /// </summary>
    public class Abstraction
    {
        /// <summary>
        /// Gets or sets the implementor.
        /// </summary>
        /// <value>
        /// The implementor.
        /// </value>
        public virtual AbstractImplementor Implementor
        {
            get
            {
                if (this._implementor == null)
                {
                    this._implementor = new AbstractImplementor();
                }

                return _implementor;
            }
            set => _implementor = value;
        }

        /// <summary>
        /// Operations this instance.
        /// </summary>
        public virtual void Operation()
        {
            Logger.Logger.Log(TAG + "Operation");
            Logger.Logger.Log(this.ToString());
            this.Implementor.OperationImp();
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        /// <exception cref="System.InvalidOperationException"></exception>
        public override string ToString()
        {
            return this.GetType().FullName ?? throw new InvalidOperationException();
        }

        /// <summary>
        /// The tag
        /// </summary>
        private const string TAG = "Abstraction ";

        /// <summary>
        /// The implementor
        /// </summary>
        private AbstractImplementor _implementor;
    }
}