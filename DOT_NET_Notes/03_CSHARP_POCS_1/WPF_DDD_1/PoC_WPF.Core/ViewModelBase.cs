// -----------------------------------------------------------------------
//  <copyright file="ViewModelBase.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using System;
using System.ComponentModel;

namespace PoC_WPF.Core
{
    using Prism.Events;
    using Prism.Regions;
    using Microsoft.Practices.ServiceLocation;
    using PropertyChanged;

    //TODO : WPF 4 Create the ViewModelBase
    //TODO : WPF 4.1 Load the Fody nuget on the Core.
    //TODO : WPF 4.2 Load the PropertyChanged.Fody Nuget on the core.
    //TODO : WPF 4.4 Load the CommonServiceLocator on the core.
    //TODO : WPF 4.5 Load the Prism.Wpf on the core
    /// <summary>
    /// ViewModel base class.
    /// </summary>
    [ImplementPropertyChanged]
    public class ViewModelBase
    {
        //TODO : WPF 4.6 Initiate the EventAggregator into the constructor.
        //TODO : WPF 4.7 Initiate the RegionManager into the constructor.
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelBase" /> class.
        /// </summary>
        public ViewModelBase()
        {
            this.EventAggregator = ServiceLocator.Current.TryResolve<IEventAggregator>();
            this.RegionManager = ServiceLocator.Current.TryResolve<IRegionManager>();
        }

        /// <summary>
        /// Gets or sets the region manager.
        /// </summary>
        /// <value>
        /// The region manager.
        /// </value>
        public IRegionManager RegionManager { get; private set; }

        //TODO : WPF 4.3 Create the "Initialize" methods.
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public void Initialize()
        {
            this.InitializeEvent();
            this.InitializeData();
            this.InitializeCommand();
        }

        /// <summary>
        /// Gets or sets the event aggregator.
        /// </summary>
        /// <value>
        /// The event aggregator.
        /// </value>
        protected IEventAggregator EventAggregator { get; private set; }

        /// <summary>
        /// Initializes the command.
        /// </summary>
        protected virtual void InitializeCommand()
        {
        }

        /// <summary>
        /// Initializes the data.
        /// </summary>
        protected virtual void InitializeData()
        {
        }

        /// <summary>
        /// Initializes the event.
        /// </summary>
        protected virtual void InitializeEvent()
        {
        }
    }
}