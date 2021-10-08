// -----------------------------------------------------------------------
//  <copyright file="FirstModule.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using Prism.Modularity;
using Prism.Regions;

namespace PoC_WPF.FirstModule
{
    //TODO : WPF3.7 Import Prism.Core 6.3.0
    //TODO : WPF3.8 Import Prism.Wpf 6.3.0
    //TODO : WPF3.9 Create module class and make it implement Prism.Modularity.IModule .
    /// <summary>
    /// First module class
    /// </summary>
    public class FirstModule : IModule
    {
        //TODO : WPF3.11 Inject the region manager into the constructor.
        /// <summary>
        /// Initializes a new instance of the <see cref="FirstModule"/> class.
        /// </summary>
        public FirstModule(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
        }

        /// <summary>
        /// Notifies the module that it has be initialized.
        /// </summary>
        public void Initialize()
        {
            //TODO : WPF3.12 Register the different view.
            //  this._regionManager.RegisterViewWithRegion(_mainRegion, typeof(Main));
            // this._regionManager.RegisterViewWithRegion(_secondaryRegion, typeof(Secondary));
        }

        /// <summary>
        /// The main region
        /// </summary>
        private const string _mainRegion = "MainRegion";

        /// <summary>
        /// The secondary region
        /// </summary>
        private const string _secondaryRegion = "SecondaryRegion";

        //TODO : WPF3.10 Create a RegionManager field.
        /// <summary>
        /// The region manager
        /// </summary>
        private readonly IRegionManager _regionManager;
    }
}