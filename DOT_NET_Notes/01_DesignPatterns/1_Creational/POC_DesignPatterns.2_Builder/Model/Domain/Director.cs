namespace POC_DesignPatterns._2_Builder.Model
{
    using POC_DesignPatterns._2_Builder.Builder;

    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Director class.
    /// </summary>
    public class Director
    {
        /// <summary>
        /// Gets or sets the structure.
        /// </summary>
        /// <value>
        /// The structure.
        /// </value>
        public IList<AbstractBuilder> Structure
        {
            get
            {
                if (this._structure == null)
                {
                    this._structure = new List<AbstractBuilder>();
                }

                return this._structure;
            }
            set => _structure = value;
        }

        /// <summary>
        /// Constructs this instance.
        /// </summary>
        public void Construct()
        {
            foreach (AbstractBuilder builder in Structure)
            {
                builder.BuildPart();
            }
        }

        /// <summary>
        /// Inspects this instance.
        /// </summary>
        public void Inspect()
        {
            foreach (AbstractBuilder builder in Structure)
            {
                Logger.Logger.Log(builder.GetResult().ToString());
            }
        }

        /// <summary>
        /// The structure
        /// </summary>
        private IList<AbstractBuilder> _structure;
    }
}