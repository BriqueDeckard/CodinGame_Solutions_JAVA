// -----------------------------------------------------------------------
//  <copyright file="IRepository.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Poc_WPF.Infrastructure.Data.UnitOfWork
{
    using System;
    using System.Linq.Expressions;
    using Poc_WPF.Domain;
    using POC_Prism.Domain;

    /// <summary>
    ///
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
        bool Add<TEntity>(TEntity item) where TEntity : class;

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