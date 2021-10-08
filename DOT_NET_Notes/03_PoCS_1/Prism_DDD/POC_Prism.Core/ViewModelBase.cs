// -----------------------------------------------------------------------
//  <copyright file="ViewModelBase.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using PropertyChanged;

namespace POC_Prism.Core
{
    using Microsoft.Practices.ServiceLocation;

    using Prism.Events;
    using Prism.Regions;

    /// <summary>
    ///
    /// </summary>
    [ImplementPropertyChanged]
    public class ViewModelBase
    {
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public void Initialize()
        {
            this.InitializeEvent();
            this.InitializeCommand();
            this.InitializeData();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelBase"/> class.
        /// </summary>
        protected ViewModelBase()
        {
            this.EventAggregator = ServiceLocator.Current.TryResolve<IEventAggregator>();
            this.RegionManager = ServiceLocator.Current.TryResolve<IRegionManager>();
        }

        /// <summary>
        /// Gets the event aggregator.
        /// </summary>
        /// <value>
        /// The event aggregator.
        /// </value>
        protected IEventAggregator EventAggregator { get; private set; }

        /// <summary>
        /// Gets the region manager.
        /// </summary>
        /// <value>
        /// The region manager.
        /// </value>
        protected IRegionManager RegionManager { get; private set; }

        /// <summary>
        /// Initializes the command.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        protected virtual void InitializeCommand()
        {
        }

        /// <summary>
        /// Initializes the data.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        protected virtual void InitializeData()
        {
        }

        /// <summary>
        /// Initializes the event.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        protected virtual void InitializeEvent()
        {
        }
    }
}