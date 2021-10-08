// -----------------------------------------------------------------------
//  <copyright file="IUnitOfWork.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace PoC_WPF.Domain
{
    using System;

    /// <summary>
    /// Interface for UnitOfWork pattern. Placed here to allow the domain to commit, rollback etc.
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Commits this instance.
        /// </summary>
        void Commit();

        /// <summary>
        /// Commits the and refresh changes.
        /// </summary>
        void CommitAndRefreshChanges();

        /// <summary>
        /// Rollbacks this instance.
        /// </summary>
        void Rollback();
    }
}