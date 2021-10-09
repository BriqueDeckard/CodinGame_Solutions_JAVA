// -----------------------------------------------------------------------
//  <copyright file="IUnitOfWork.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using System;

namespace Poc_WPF.Domain
{
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
        /// Rollbacks the changes.
        /// </summary>
        void Rollback();
    }
}