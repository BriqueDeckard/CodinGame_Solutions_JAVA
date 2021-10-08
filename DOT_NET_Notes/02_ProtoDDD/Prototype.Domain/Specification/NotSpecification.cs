using System;
using System.Linq;
using System.Linq.Expressions;
using Prototype.Domain.Contracts.SeedWork;

namespace Prototype.Domain.Specification
{
    public sealed class NotSpecification<TEntity> : Specification<TEntity> where TEntity : class
    {
        #region ---- Fields ----

        /// <summary>
        ///     The original criteria.
        /// </summary>
        private readonly Expression<Func<TEntity, bool>> _originalCriteria;

        #endregion

        #region ---- Override Methods -----

        /// <summary>
        ///     Satisfied the by.
        /// </summary>
        /// <returns>Lambda expression.</returns>
        public override Expression<Func<TEntity, bool>> IsSatisfiedBy()
        {
            return Expression.Lambda<Func<TEntity, bool>>(Expression.Not(_originalCriteria.Body),
                _originalCriteria.Parameters.Single());
        }

        #endregion

        #region ----- Constructor -----

        /// <summary>
        ///     Initializes a new instance of the <see cref="NotSpecification{TEntity}" /> class.
        /// </summary>
        /// <param name="originalSpecification">The original specification.</param>
        public NotSpecification(ISpecification<TEntity> originalSpecification)
        {
            _originalCriteria = originalSpecification?.IsSatisfiedBy() ??
                                throw new ArgumentNullException(nameof(originalSpecification));
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="NotSpecification{TEntity}" /> class.
        /// </summary>
        /// <param name="originalSpecification">The original specification.</param>
        public NotSpecification(Expression<Func<TEntity, bool>> originalSpecification)
        {
            _originalCriteria = originalSpecification ?? throw new ArgumentNullException(nameof(originalSpecification));
        }

        #endregion
    }
}