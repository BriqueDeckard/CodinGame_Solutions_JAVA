// -----------------------------------------------------------------------
//  <copyright file="IUnitOfWork.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace POC_Prism.Domain
{
    using System;

    //TODO : UoW 2
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