// -----------------------------------------------------------------------
//  <copyright file="GenericRepository.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace POC_Prism.Infrastructure.data.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using POC_Prism.Domain.Specification;
    using System;
    using System.Data.Entity;
    using POC_Prism.Domain;
    using POC_Prism.Infrastructure.data.UnitOfWork;

    //TODO : UoW 4
    /// <summary>
    /// Generic repository
    /// </summary>
    /// <seealso cref="POC_Prism.Infrastructure.data.UnitOfWork.IRepository" />
    internal class GenericRepository : IRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericRepository" /> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <exception cref="ArgumentNullException">context</exception>
        public GenericRepository(IUnitOfWork context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (context is POC_PrismContext ctx)
            {
                this._context = ctx;
            }
        }

        /// <summary>
        /// Gets the unit of work.
        /// </summary>
        /// <value>
        /// The unit of work.
        /// </value>
        public IUnitOfWork UnitOfWork
        {
            get => this._context;
        }

        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="item">The item.</param>
        /// <exception cref="ArgumentNullException">item</exception>
        public virtual void Add<TEntity>(TEntity item)
        where TEntity : class
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            this._context.Set<TEntity>().Add(item);
        }

        /// <summary>
        /// Gets the by filter.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity
        /// .</typeparam>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <param name="predicate">The predicate.</param>
        /// <param name="order">The order.</param>
        /// <param name="ascending">if set to <c>true</c> [ascending].</param>
        /// <returns></returns>
        public virtual IEnumerable<TEntity> GetByFilter<TEntity, TKey>(
            Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, TKey>> order,
            bool ascending)
        where TEntity : class, IEntity
        {
            //TKEY est le filtre order
            DbSet<TEntity> objectSet = this._context.Set<TEntity>();
            if (predicate != null)
            {
            }

            var query = objectSet.Where(predicate);
            if (ascending)
            {
                query = query.OrderBy(order);
            }
            else
            {
                query = query.OrderByDescending(order);
            }

            return query.AsEnumerable();
        }

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
        /// <exception cref="ArgumentNullException"></exception>
        public virtual IEnumerable<TResult> GetByFilter<TEntity, TKey, TResult>(

            Expression<Func<TEntity, TResult>> selectResult,
            Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, TKey>> order,
            bool ascending)
            where TEntity : class, IEntity
        {
            //TKEY est le filtre order
            var objectSet = this._context.Set<TEntity>();
            if (predicate != null)
            {
                throw new ArgumentNullException();
            }

            var query = objectSet.Where(predicate);
            if (ascending)
            {
                query = query.OrderBy(order);
            }
            else
            {
                query = query.OrderByDescending(order);
            }

            var result = query.Select(selectResult);

            return result.AsEnumerable();
        }

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
        /// <exception cref="ArgumentNullException"></exception>
        public virtual IEnumerable<TResult> GetByFilter<TEntity, TKey, TResult>(
            Expression<Func<TEntity, TResult>> selectResult,
            ISpecification<TEntity> specification,
            Expression<Func<TEntity, TKey>> order,
            bool ascending)
            where TEntity : class, IEntity
        {
            //TKEY est le filtre order
            DbSet<TEntity> objectSet = this._context.Set<TEntity>();
            if (specification == null)
            {
                throw new ArgumentNullException();
                //TODO : Log
            }

            IQueryable<TEntity> query = objectSet.Where(specification.SatisfiedBy());

            if (ascending)
            {
                query = query.OrderBy(order);
            }
            else
            {
                query = query.OrderByDescending(order);
            }

            IQueryable<TResult> result = query.Select(selectResult);

            return result.AsEnumerable();
        }

        /// <summary>
        /// Gets the entity.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="id">The identifier.</param>
        /// <param name="includes">The includes.</param>
        /// <returns></returns>
        public virtual TEntity GetEntity<TEntity>(int id, params Expression<Func<TEntity, object>>[] includes)
        where TEntity : class, IEntity
        {
            DbSet<TEntity> objectSet = this._context.Set<TEntity>();

            IQueryable<TEntity> query = objectSet.Where(w => w.Id == id);

            if (includes != null)
            {
                // objectSet.Include(includes);
                //Or
                includes.Aggregate(query, (current, include) => current.Include(include));
            }

            //Run the query at the end.
            return query.FirstOrDefault();
        }

        /// <summary>
        /// Modifies the specified item.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity
        /// .</typeparam>
        /// <param name="item">The item.</param>
        /// <exception cref="ArgumentNullException">item</exception>
        public virtual void Modify<TEntity>(TEntity item)
        where TEntity : class
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (this._context.Entry(item).State != EntityState.Modified)
            {
                //Changes its status to indicate that it has been modified.
                this._context.Entry(item).State = EntityState.Modified;
            }
        }

        /// <summary>
        /// Removes the specified item.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="item">The item.</param>
        /// <exception cref="ArgumentNullException">item</exception>
        public virtual void Remove<TEntity>(TEntity item) where TEntity : class
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            IDbSet<TEntity> objectSet = this._context.Set<TEntity>();

            objectSet.Attach(item);

            objectSet.Remove(item);
        }

        /// <summary>
        /// The context
        /// </summary>
        private readonly POC_PrismContext _context;
    }
}