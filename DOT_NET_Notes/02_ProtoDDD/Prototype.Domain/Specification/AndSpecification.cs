using System;
using System.Linq.Expressions;
using Prototype.Domain.Contracts.SeedWork;

namespace Prototype.Domain.Specification
{
    /// <summary>
    ///     And specification
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <seealso cref="Prototype.Domain.Specification.CompositeSpecification&lt;TEntity&gt;" />
    public sealed class AndSpecification<TEntity> : CompositeSpecification<TEntity> where TEntity : class
    {
        /// <summary>
        ///     The left side specification.
        /// </summary>
        private readonly ISpecification<TEntity> _leftSideSpecification;

        /// <summary>
        ///     The right side specification.
        /// </summary>
        private readonly ISpecification<TEntity> _rightSideSpecification;

        #region ----- Constructor -----

        /// <summary>
        ///     Initializes a new instance of the <see cref="AndSpecification{TEntity}" /> class.
        /// </summary>
        /// <param name="leftSide">Left side specification.</param>
        /// <param name="rightSide">Right side specification.</param>
        public AndSpecification(ISpecification<TEntity> leftSide, ISpecification<TEntity> rightSide)
        {
            _leftSideSpecification = leftSide ?? throw new ArgumentNullException(nameof(leftSide));

            _rightSideSpecification = rightSide ?? throw new ArgumentNullException(nameof(rightSide));
        }

        #endregion

        #region ----- Override Methods -----

        /// <summary>
        ///     Gets the Left side specification.
        /// </summary>
        public override ISpecification<TEntity> LeftSideSpecification => _leftSideSpecification;

        /// <summary>
        ///     Gets the Right side specification.
        /// </summary>
        public override ISpecification<TEntity> RightSideSpecification => _rightSideSpecification;

        /// <summary>
        ///     Satisfied the by.
        /// </summary>
        /// <returns>The expression.</returns>
        public override Expression<Func<TEntity, bool>> IsSatisfiedBy()
        {
            var left = _leftSideSpecification.IsSatisfiedBy();
            var right = _rightSideSpecification.IsSatisfiedBy();

            return left.And(right);
        }

        #endregion
    }
}