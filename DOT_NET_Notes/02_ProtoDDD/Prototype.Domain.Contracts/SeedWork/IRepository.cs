using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Prototype.Domain.Contracts.SeedWork
{
    /// <summary>
    ///     Contract for the Generic repository.<br />
    ///     Using a repository allows:<br />
    ///     <list type="bullet">
    ///         <item>Encapsulate the logic for obtaining object references.</item>
    ///         <item>Store objects</item>
    ///         <item>To use a particular strategy to apply to access an object.</item>
    ///     </list>
    ///     The implementation of a repository can be done in the infrastructure
    ///     layer however the interface of this repository is part of the model.
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        ///     UnitOfWork to ensure persistence
        /// </summary>
        IUnitOfWork UnitOfWork { get; }

        /// <summary>
        ///     Adding an entity
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        public void AddEntity<TEntity>(TEntity entity) where TEntity : class;

        /// <summary>
        ///     Getting an entity
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity GetEntity<TEntity>(int id) where TEntity : class, IAggregateRoot, IEntity;

        /// <summary>
        ///     Getting all the entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll<TEntity>() where TEntity : class, IEntity;

        /// <summary>
        ///     Removing an entity
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        public bool RemoveEntity<TEntity>(TEntity entity) where TEntity : Entity;

        /// <summary>
        ///     Getting all the entities corresponding to a given filter.
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="predicate"></param>
        /// <param name="order"></param>
        /// <param name="ascending"></param>
        /// <returns></returns>
        IEnumerable<TEntity> GetByFilter<TEntity, TKey>(
            Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, TKey>> order,
            bool ascending)
            where TEntity : class, IEntity;

        /// <summary>
        ///     Getting all the entities corresponding to a given filter.
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="selectResult"></param>
        /// <param name="predicate"></param>
        /// <param name="order"></param>
        /// <param name="ascending"></param>
        /// <returns></returns>
        public IEnumerable<TResult> GetByFilter<TEntity, TKey, TResult>(
            Expression<Func<TEntity, TResult>> selectResult,
            Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, TKey>> order,
            bool ascending)
            where TEntity : class, IEntity;

        /// <summary>
        ///     Getting all the entities corresponding to a given filter.
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="selectResult"></param>
        /// <param name="specification"></param>
        /// <param name="order"></param>
        /// <param name="ascending"></param>
        /// <returns></returns>
        public IEnumerable<TResult> GetByFilter<TEntity, TKey, TResult>(
            Expression<Func<TEntity, TResult>> selectResult,
            ISpecification<TEntity> specification,
            Expression<Func<TEntity, TKey>> order,
            bool ascending)
            where TEntity : class, IEntity;
    }
}