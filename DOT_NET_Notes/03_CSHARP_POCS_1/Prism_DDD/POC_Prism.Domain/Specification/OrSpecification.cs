// --------------------------------------------------------------------
// <copyright file="OrSpecification.cs" company="Modis">
//     Copyright (c) . All rights reserved.
// </copyright>
// --------------------------------------------------------------------

namespace  POC_Prism.Domain.Specification
{
    using System;
    using System.Linq.Expressions;

    /// <summary>
    /// A Logic OR Specification.
    /// </summary>
    /// <typeparam name="T">Type of entity that check this specification.</typeparam>
    public sealed class OrSpecification<T> : CompositeSpecification<T>
         where T : class
    {
        #region ----- Members -----

        /// <summary>
        /// The left side specification.
        /// </summary>
        private readonly ISpecification<T> _leftSideSpecification = null;

        /// <summary>
        /// The right side specification.
        /// </summary>
        private readonly ISpecification<T> _rightSideSpecification = null;

        #endregion

        #region ----- Constructor -----

        /// <summary>
        /// Initializes a new instance of the <see cref="OrSpecification{T}"/> class.
        /// </summary>
        /// <param name="leftSide">The left side.</param>
        /// <param name="rightSide">The right side.</param>
        public OrSpecification(ISpecification<T> leftSide, ISpecification<T> rightSide)
        {
            this._leftSideSpecification = leftSide ?? throw new ArgumentNullException(nameof(leftSide));

            this._rightSideSpecification = rightSide ?? throw new ArgumentNullException(nameof(rightSide));
        }

        #endregion

        #region ----- Overrides Methods -----

        /// <summary>
        /// Gets the Left side specification.
        /// </summary>
        public override ISpecification<T> LeftSideSpecification => this._leftSideSpecification;

        /// <summary>
        /// Gets the Right side specification.
        /// </summary>
        public override ISpecification<T> RightSideSpecification => this._rightSideSpecification;

        /// <summary>
        /// Satisfied the by.
        /// </summary>
        /// <returns>Lambda expression.</returns>
        public override Expression<Func<T, bool>> SatisfiedBy()
        {
            var left = this._leftSideSpecification.SatisfiedBy();
            var right = this._rightSideSpecification.SatisfiedBy();

            return left.Or(right);
        }

        #endregion
    }
}