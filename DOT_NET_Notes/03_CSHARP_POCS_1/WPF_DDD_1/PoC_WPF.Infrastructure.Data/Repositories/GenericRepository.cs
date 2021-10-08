// -----------------------------------------------------------------------
//  <copyright file="GenericRepository.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace PoC_WPF.Infrastructure.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Linq;
    using PoC_WPF.Domain;
    using PoC_WPF.Infrastructure.Data.UnitOfWork;

    //TODO : WPF 5.3 Create a generic repository that implements IRepository.
    /// <summary>
    /// Generic repository for entities.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <seealso cref="PoC_WPF.Infrastructure.Data.UnitOfWork.IRepository{TEntity}" />
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        //TODO:  WPF5.5 Inject and cast the context
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

            if (context is PoC_Context ctx)
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
        /// <param name="item">The item.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">item</exception>
        public bool Add(TEntity item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            this._context.Set<TEntity>().Add(item);
            this._context.CommitAndRefreshChanges();
            return true;
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TEntity> GetAll()
        {
            DbSet<TEntity> objectSet = this._context.Set<TEntity>();
            return objectSet.ToList();
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public TEntity GetById(int id)
        {
            DbSet<TEntity> objectSet = this._context.Set<TEntity>();

            var query = objectSet.ToList();

            return query.FirstOrDefault(w => w.Id == id);
        }

        /// <summary>
        /// The context
        /// </summary>
        private readonly PoC_Context _context;
    }
}