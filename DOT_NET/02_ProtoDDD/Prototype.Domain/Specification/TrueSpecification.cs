using System;
using System.Linq.Expressions;

namespace Prototype.Domain.Specification
{
    public class TrueSpecification<TEntity> : Specification<TEntity> where TEntity : class
    {
        #region ----- overrides Methods -----

        /// <summary>
        ///     <see cref=" Specification{TEntity}" />
        /// </summary>
        /// <returns><see cref=" Specification{TEntity}" /> return true.</returns>
        public override Expression<Func<TEntity, bool>> IsSatisfiedBy()
        {
            // Create "result variable" transform adhoc execution plan in prepared plan for more info: http://geeks.ms/blogs/unai/2010/07/91/ef-4-0-performance-tips-1.aspx
            var result = true;

            Expression<Func<TEntity, bool>> trueExpression = t => result;
            return trueExpression;
        }

        #endregion
    }
}