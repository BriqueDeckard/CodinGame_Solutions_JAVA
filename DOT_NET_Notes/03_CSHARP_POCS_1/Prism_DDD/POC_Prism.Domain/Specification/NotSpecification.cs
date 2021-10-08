// --------------------------------------------------------------------
// <copyright file="NotSpecification.cs" company="Modis">
//     Copyright (c) . All rights reserved.
// </copyright>
// --------------------------------------------------------------------

namespace  POC_Prism.Domain.Specification
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    /// <summary>
    /// Not Specification convert a original specification with NOT logic operator.
    /// </summary>
    /// <typeparam name="TEntity">Type of element for this specification.</typeparam>
    public sealed class NotSpecification<TEntity> : Specification<TEntity>
        where TEntity : class
    {
        #region ---- Fields ----

        /// <summary>
        /// The original criteria.
        /// </summary>
        private readonly Expression<Func<TEntity, bool>> _originalCriteria;

        #endregion

        #region ----- Constructor -----

        /// <summary>
        /// Initializes a new instance of the <see cref="NotSpecification{TEntity}"/> class.
        /// </summary>
        /// <param name="originalSpecification">The original specification.</param>
        public NotSpecification(ISpecification<TEntity> originalSpecification)
        {
            this._originalCriteria = originalSpecification?.SatisfiedBy() ?? throw new ArgumentNullException(nameof(originalSpecification));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotSpecification{TEntity}"/> class.
        /// </summary>
        /// <param name="originalSpecification">The original specification.</param>
        public NotSpecification(Expression<Func<TEntity, bool>> originalSpecification)
        {
            this._originalCriteria = originalSpecification ?? throw new ArgumentNullException(nameof(originalSpecification));
        }

        #endregion

        #region ---- Override Methods -----

        /// <summary>
        /// Satisfied the by.
        /// </summary>
        /// <returns>Lambda expression.</returns>
        public override Expression<Func<TEntity, bool>> SatisfiedBy()
        {
            return Expression.Lambda<Func<TEntity, bool>>(Expression.Not(this._originalCriteria.Body), this._originalCriteria.Parameters.Single());
        }

        #endregion
    }
}