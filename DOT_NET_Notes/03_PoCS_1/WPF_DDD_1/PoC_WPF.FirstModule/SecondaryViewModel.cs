// -----------------------------------------------------------------------
//  <copyright file="SecondaryViewModel.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using System;
using PoC_WPF.Core;
using Prism.Commands;

namespace PoC_WPF.FirstModule
{
    /// <summary>
    /// View model class for secondary view.
    /// </summary>
    /// <seealso cref="PoC_WPF.Core.ViewModelBase" />
    public class SecondaryViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets the change command.
        /// </summary>
        /// <value>
        /// The change command.
        /// </value>
        public DelegateCommand ChangeCommand => new DelegateCommand(this.Change);

        /// <summary>
        /// The main region
        /// </summary>
        private const string mainRegion = "MainRegion";

        /// <summary>
        /// The primary
        /// </summary>
        private const string primary = "PoC_WPF.FirstModule.Main";

        /// <summary>
        /// Changes this instance.
        /// </summary>
        private void Change()
        {
            this.RegionManager.RegisterViewWithRegion(mainRegion, typeof(Main));
            this.RegionManager.RequestNavigate(mainRegion, new Uri(primary, UriKind.Relative));
        }
    }
}