using Prototype.Domain.Contracts.SeedWork;

namespace Prototype.Domain.Specification
{
    public abstract class CompositeSpecification<TEntity> : Specification<TEntity> where TEntity : class
    {
        #region ----- Properties -----

        /// <summary>
        ///     Gets the Left side specification for this composite element.
        /// </summary>
        public abstract ISpecification<TEntity> LeftSideSpecification { get; }

        /// <summary>
        ///     Gets the Right side specification for this composite element.
        /// </summary>
        public abstract ISpecification<TEntity> RightSideSpecification { get; }

        #endregion ----- Properties -----
    }
}