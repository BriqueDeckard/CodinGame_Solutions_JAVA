// -----------------------------------------------------------------------
//  <copyright file="IViewModelBase.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Poc_WPF.Core
{
    using System;

    /// <summary>
    /// Interface for ViewModelBase
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public interface IViewModelBase : IDisposable
    {
        /// <summary>
        /// Exécute les tâches définies par l’application associées à la libération ou à la redéfinition des ressources non managées.
        /// </summary>
        void Dispose();

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        void Dispose(bool disposing);

        /// <summary>
        /// Initializes the command.
        /// </summary>
        void InitializeCommand();

        /// <summary>
        /// Initializes the data.
        /// </summary>
        void InitializeData();

        /// <summary>
        /// Initializes the event.
        /// </summary>
        void InitializeEvent();
    }