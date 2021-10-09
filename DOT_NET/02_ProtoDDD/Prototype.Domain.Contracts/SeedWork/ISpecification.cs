using System;
using System.Linq.Expressions;

namespace Prototype.Domain.Contracts.SeedWork
{
    /// <summary>
    ///     Contract for specification.
    ///     <para>
    ///         Specification pattern is a pattern that allows us to
    ///         encapsulate some piece of domain knowledge into a single
    ///         unit - specification - and reuse it in different parts
    ///         of the code base.
    ///     </para>
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public interface ISpecification<TEntity> where TEntity : class
    {
        /// <summary>
        ///     Determines whether [is satisfied by].
        /// </summary>
        /// <returns></returns>
        Expression<Func<TEntity, bool>> IsSatisfiedBy();
    }
}