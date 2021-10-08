// --------------------------------------------------------------------
// <copyright file="AndSpecification.cs" company="Modis">
//     Copyright (c) . All rights reserved.
// </copyright>
// --------------------------------------------------------------------

namespace POC_Prism.Domain.Specification
{
    using System;
    using System.Linq.Expressions;

    /// <summary>
    /// A logic AND Specification.
    /// </summary>
    /// <typeparam name="TEntity">Type of entity that check this specification.</typeparam>
    public sealed class AndSpecification<TEntity> : CompositeSpecification<TEntity>
       where TEntity : class
    {
        /// <summary>
        /// The left side specification.
        /// </summary>
        private readonly ISpecification<TEntity> _leftSideSpecification;

        /// <summary>
        /// The right side specification.
        /// </summary>
        private readonly ISpecification<TEntity> _rightSideSpecification;

        #region ----- Constructor -----

        /// <summary>
        /// Initializes a new instance of the <see cref="AndSpecification{TEntity}"/> class.
        /// </summary>
        /// <param name="leftSide">Left side specification.</param>
        /// <param name="rightSide">Right side specification.</param>
        public AndSpecification(ISpecification<TEntity> leftSide, ISpecification<TEntity> rightSide)
        {
            this._leftSideSpecification = leftSide ?? throw new ArgumentNullException(nameof(leftSide));

            this._rightSideSpecification = rightSide ?? throw new ArgumentNullException(nameof(rightSide));
        }

        #endregion

        #region ----- Override Methods -----

        /// <summary>
        /// Gets the Left side specification.
        /// </summary>
        public override ISpecification<TEntity> LeftSideSpecification => this._leftSideSpecification;

        /// <summary>
        /// Gets the Right side specification.
        /// </summary>
        public override ISpecification<TEntity> RightSideSpecification => this._rightSideSpecification;

        /// <summary>
        /// Satisfied the by.
        /// </summary>
        /// <returns>The expression.</returns>
        public override Expression<Func<TEntity, bool>> SatisfiedBy()
        {
            var left = this._leftSideSpecification.SatisfiedBy();
            var right = this._rightSideSpecification.SatisfiedBy();

            return left.And(right);
        }

        #endregion
    }
}