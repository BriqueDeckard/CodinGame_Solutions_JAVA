// --------------------------------------------------------------------
// <copyright file="TrueSpecification.cs" company="Modis">
//     Copyright (c) . All rights reserved.
// </copyright>
// --------------------------------------------------------------------

namespace  POC_Prism.Domain.Specification
{
    using System;
    using System.Linq.Expressions;

    /// <summary>
    /// True specification
    /// </summary>
    /// <typeparam name="TEntity">Type of entity in this specification</typeparam>
    public sealed class TrueSpecification<TEntity> : Specification<TEntity>
        where TEntity : class
    {
        #region ----- overrides Methods -----

        /// <summary>
        /// <see cref=" Specification{TEntity}"/>
        /// </summary>
        /// <returns><see cref=" Specification{TEntity}"/> return true.</returns>
        public override Expression<Func<TEntity, bool>> SatisfiedBy()
        {
            // Create "result variable" transform adhoc execution plan in prepared plan for more info: http://geeks.ms/blogs/unai/2010/07/91/ef-4-0-performance-tips-1.aspx
            var result = true;

            Expression<Func<TEntity, bool>> trueExpression = t => result;
            return trueExpression;
        }

        #endregion
    }
}