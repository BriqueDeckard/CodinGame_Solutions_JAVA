using System;
using System.Linq.Expressions;
using Prototype.Domain.Contracts.SeedWork;

namespace Prototype.Domain.Specification
{
    public sealed class OrSpecification<T> : CompositeSpecification<T> where T : class
    {
        #region ----- Constructor -----

        /// <summary>
        ///     Initializes a new instance of the <see cref="OrSpecification{T}" /> class.
        /// </summary>
        /// <param name="leftSide">The left side.</param>
        /// <param name="rightSide">The right side.</param>
        public OrSpecification(ISpecification<T> leftSide, ISpecification<T> rightSide)
        {
            _leftSideSpecification = leftSide ?? throw new ArgumentNullException(nameof(leftSide));

            _rightSideSpecification = rightSide ?? throw new ArgumentNullException(nameof(rightSide));
        }

        #endregion

        #region ----- Members -----

        /// <summary>
        ///     The left side specification.
        /// </summary>
        private readonly ISpecification<T> _leftSideSpecification;

        /// <summary>
        ///     The right side specification.
        /// </summary>
        private readonly ISpecification<T> _rightSideSpecification;

        #endregion

        #region ----- Overrides Methods -----

        /// <summary>
        ///     Gets the Left side specification.
        /// </summary>
        public override ISpecification<T> LeftSideSpecification => _leftSideSpecification;

        /// <summary>
        ///     Gets the Right side specification.
        /// </summary>
        public override ISpecification<T> RightSideSpecification => _rightSideSpecification;

        /// <summary>
        ///     Satisfied the by.
        /// </summary>
        /// <returns>Lambda expression.</returns>
        public override Expression<Func<T, bool>> IsSatisfiedBy()
        {
            var left = _leftSideSpecification.IsSatisfiedBy();
            var right = _rightSideSpecification.IsSatisfiedBy();

            return left.Or(right);
        }

        #endregion
    }
}