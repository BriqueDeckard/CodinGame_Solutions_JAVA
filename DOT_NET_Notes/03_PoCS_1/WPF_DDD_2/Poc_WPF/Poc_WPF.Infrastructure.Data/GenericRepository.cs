// -----------------------------------------------------------------------
//  <copyright file="GenericRepository.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Poc_WPF.Infrastructure.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;
    using Poc_WPF.Domain;
    using Poc_WPF.Infrastructure.Data.UnitOfWork;
    using POC_Prism.Domain;

    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Poc_WPF.Infrastructure.Data.UnitOfWork.IRepository" />
    public class GenericRepository : IRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public GenericRepository(IUnitOfWork context)
        {
            if (context == null)
            {
                throw new ArgumentNullException();
            }

            if (context is Poc_WPFContext ctx)
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
        public IUnitOfWork UnitOfWork { get; }

        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="item">The item.</param>
        /// <exception cref="System.ArgumentNullException">item</exception>
        public bool Add<TEntity>(TEntity item) where TEntity : class
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            try
            {
                this._context.Set<TEntity>().Add(item);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gets the entity.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="id">The identifier.</param>
        /// <param name="includes">The includes.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public TEntity GetEntity<TEntity>(int id, params Expression<Func<TEntity, object>>[] includes) where TEntity : class, IEntity
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
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="item">The item.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Modify<TEntity>(TEntity item) where TEntity : class
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
        /// <exception cref="System.NotImplementedException"></exception>
        public void Remove<TEntity>(TEntity item) where TEntity : class
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
        private Poc_WPFContext _context;
    }
}