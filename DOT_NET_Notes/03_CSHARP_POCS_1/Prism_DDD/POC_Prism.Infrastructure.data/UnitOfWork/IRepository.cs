// -----------------------------------------------------------------------
//  <copyright file="IRepository.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------
namespace POC_Prism.Infrastructure.data.UnitOfWork
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using POC_Prism.Domain;
    using POC_Prism.Domain.Specification;

    /// <summary>
    /// Interface for repository class.
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Gets the unit of work.
        /// </summary>
        /// <value>
        /// The unit of work.
        /// </value>
        IUnitOfWork UnitOfWork { get; }

        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="item">The item.</param>
        void Add<TEntity>(TEntity item) where TEntity : class;

        /// <summary>
        /// Gets the by filter.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <param name="predicate">The predicate.</param>
        /// <param name="order">The order.</param>
        /// <param name="ascending">if set to <c>true</c> [ascending].</param>
        /// <returns></returns>
        IEnumerable<TEntity> GetByFilter<TEntity, TKey>(
            Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, TKey>> order,
            bool ascending)
            where TEntity : class, IEntity;

        /// <summary>
        /// Gets the by filter.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="selectResult">The select result.</param>
        /// <param name="predicate">The predicate.</param>
        /// <param name="order">The order.</param>
        /// <param name="ascending">if set to <c>true</c> [ascending].</param>
        /// <returns></returns>
        IEnumerable<TResult> GetByFilter<TEntity, TKey, TResult>(

            Expression<Func<TEntity, TResult>> selectResult,
            Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, TKey>> order,
            bool ascending)
            where TEntity : class, IEntity;

        /// <summary>
        /// Gets the by filter.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="selectResult">The select result.</param>
        /// <param name="specification">The specification.</param>
        /// <param name="order">The order.</param>
        /// <param name="ascending">if set to <c>true</c> [ascending].</param>
        /// <returns></returns>
        IEnumerable<TResult> GetByFilter<TEntity, TKey, TResult>(
            Expression<Func<TEntity, TResult>> selectResult,
            ISpecification<TEntity> specification,
            Expression<Func<TEntity, TKey>> order,
            bool ascending)
            where TEntity : class, IEntity;

        /// <summary>
        /// Gets the entity.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="id">The identifier.</param>
        /// <param name="includes">The includes.</param>
        /// <returns></returns>
        TEntity GetEntity<TEntity>(int id, params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class, IEntity;

        /// <summary>
        /// Modifies the specified item.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="item">The item.</param>
        void Modify<TEntity>(TEntity item)
            where TEntity : class;

        /// <summary>
        /// Removes the specified item.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="item">The item.</param>
        void Remove<TEntity>(TEntity item) where TEntity : class;
    }
}