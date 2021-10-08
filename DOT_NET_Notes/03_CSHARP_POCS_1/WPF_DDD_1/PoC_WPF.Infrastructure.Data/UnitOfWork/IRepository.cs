// -----------------------------------------------------------------------
//  <copyright file="IRepository.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using PoC_WPF.Domain;

namespace PoC_WPF.Infrastructure.Data.UnitOfWork
{
    //TODO : WPF 5.2 creates the InfrastructureData library, then Repositories and UnitOfWork folders, then IRepository interface.
    /// <summary>
    /// Interface for UnitOfWork repository
    /// </summary>
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="item">The item.</param>
        bool Add(TEntity item);

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        TEntity GetById(int id);
    }
}