// --------------------------------------------------------------------
// <copyright file="CompositeSpecification.cs" company="Modis">
//     Copyright (c) . All rights reserved.
// </copyright>
// --------------------------------------------------------------------

namespace  POC_Prism.Domain.Specification
{
    /// <summary>
    /// Base class for composite specifications.
    /// </summary>
    /// <typeparam name="TEntity">
    /// Type of entity that check this specification.
    /// </typeparam>
    public abstract class CompositeSpecification<TEntity> : Specification<TEntity>
         where TEntity : class
    {
        #region ----- Properties -----

        /// <summary>
        /// Gets the Left side specification for this composite element.
        /// </summary>
        public abstract ISpecification<TEntity> LeftSideSpecification { get; }

        /// <summary>
        /// Gets the Right side specification for this composite element.
        /// </summary>
        public abstract ISpecification<TEntity> RightSideSpecification { get; }

        #endregion ----- Properties -----
    }
}