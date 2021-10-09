using System;
using System.Linq.Expressions;
using Prototype.Domain.Contracts.SeedWork;

namespace Prototype.Domain.Specification
{
    public abstract class Specification<TEntity> : ISpecification<TEntity> where TEntity : class
    {
        #region ----- ISpecification<TEntity> Members -----

        /// <summary>
        ///     Satisfied by Specification pattern method.
        /// </summary>
        /// <returns>Expression that satisfy this specification.</returns>
        public abstract Expression<Func<TEntity, bool>> IsSatisfiedBy();

        #endregion

        #region ----- Override Operators -----

        /// <summary>
        ///     Gets the Override operator false, only for support AND OR operators.
        /// </summary>
        /// <returns>See False operator in C#.</returns>
        public bool IsFalse => false;

        /// <summary>
        ///     Gets the Override operator True, only for support AND OR operators.
        /// </summary>
        /// <returns>See True operator in C#.</returns>
        public bool IsTrue => true;

        /// <summary>
        ///     Not specification.
        /// </summary>
        /// <param name="specification">Specification to negate.</param>
        /// <returns>New specification.</returns>
        public static Specification<TEntity> operator !(Specification<TEntity> specification)
        {
            return new NotSpecification<TEntity>(specification);
        }

        /// <summary>
        ///     And operator.
        /// </summary>
        /// <param name="leftSideSpecification">Left operand in this AND operation.</param>
        /// <param name="rightSideSpecification">Right operand in this AND operation.</param>
        /// <returns>New specification.</returns>
        public static Specification<TEntity> operator &(Specification<TEntity> leftSideSpecification,
            Specification<TEntity> rightSideSpecification)
        {
            return new AndSpecification<TEntity>(leftSideSpecification, rightSideSpecification);
        }

        /// <summary>
        ///     Or operator.
        /// </summary>
        /// <param name="leftSideSpecification">Left operand in this OR operation.</param>
        /// <param name="rightSideSpecification">Right operand in this OR operation.</param>
        /// <returns>New specification.</returns>
        public static Specification<TEntity> operator |(Specification<TEntity> leftSideSpecification,
            Specification<TEntity> rightSideSpecification)
        {
            return new OrSpecification<TEntity>(leftSideSpecification, rightSideSpecification);
        }

        /// <summary>
        ///     Override operator false, only for support AND OR operators.
        /// </summary>
        /// <param name="specification">Specification instance.</param>
        /// <returns>See False operator in C#.</returns>
        public static bool operator false(Specification<TEntity> specification)
        {
            if (specification == null) throw new ArgumentNullException(nameof(specification));

            return false;
        }

        /// <summary>
        ///     Override operator True, only for support AND OR operators.
        /// </summary>
        /// <param name="specification">Specification instance.</param>
        /// <returns>See True operator in C#.</returns>
        public static bool operator true(Specification<TEntity> specification)
        {
            if (specification == null) throw new ArgumentNullException(nameof(specification));

            return true;
        }

        /// <summary>
        ///     And operator.
        /// </summary>
        /// <param name="leftSideSpecification">Left operand in this AND operation.</param>
        /// <param name="rightSideSpecification">Right operand in this AND operation.</param>
        /// <returns>New specification.</returns>
        public Specification<TEntity> BitwiseAnd(Specification<TEntity> leftSideSpecification,
            Specification<TEntity> rightSideSpecification)
        {
            return new AndSpecification<TEntity>(leftSideSpecification, rightSideSpecification);
        }

        /// <summary>
        ///     Or operator.
        /// </summary>
        /// <param name="leftSideSpecification">Left operand in this OR operation.</param>
        /// <param name="rightSideSpecification">Right operand in this OR operation.</param>
        /// <returns>New specification.</returns>
        public Specification<TEntity> BitwiseOr(Specification<TEntity> leftSideSpecification,
            Specification<TEntity> rightSideSpecification)
        {
            return new OrSpecification<TEntity>(leftSideSpecification, rightSideSpecification);
        }

        /// <summary>
        ///     Not specification.
        /// </summary>
        /// <param name="specification">Specification to negate.</param>
        /// <returns>New specification.</returns>
        public Specification<TEntity> LogicalNot(Specification<TEntity> specification)
        {
            return new NotSpecification<TEntity>(specification);
        }

        #endregion
    }
}