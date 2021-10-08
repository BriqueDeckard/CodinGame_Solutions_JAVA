using System;
using System.Linq.Expressions;

namespace Prototype.Domain.Specification
{
    public class DirectSpecification<TEntity> : Specification<TEntity> where TEntity : class
    {
        /// <summary>
        ///     The matching criteria.
        /// </summary>
        private readonly Expression<Func<TEntity, bool>> _matchingCriteria;

        #region ----- Constructor -----

        /// <summary>
        ///     Initializes a new instance of the <see cref="DirectSpecification{TEntity}" /> class.
        /// </summary>
        /// <param name="matchingCriteria">The matching criteria.</param>
        public DirectSpecification(Expression<Func<TEntity, bool>> matchingCriteria)
        {
            _matchingCriteria = matchingCriteria ?? throw new ArgumentNullException(nameof(matchingCriteria));
        }

        #endregion

        #region ----- Override Method -----

        /// <summary>
        ///     Satisfied By Pattern.
        /// </summary>
        /// <returns>The expression.</returns>
        public override Expression<Func<TEntity, bool>> IsSatisfiedBy()
        {
            return _matchingCriteria;
        }

        #endregion
    }
}