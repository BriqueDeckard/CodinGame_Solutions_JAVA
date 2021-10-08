// -----------------------------------------------------------------------
//  <copyright file="MainViewModel.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Prism.Commands;

namespace PoC_WPF.FirstModule
{
    using PoC_WPF.Core;

    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets the change command.
        /// </summary>
        /// <value>
        /// The change command.
        /// </value>
        public DelegateCommand ChangeCommand => new DelegateCommand(this.Change);

        public List<thing> sourceList
        {
            get => _sourceList;
            set => _sourceList = value;
        }

        /// <summary>
        /// The main region
        /// </summary>
        private const string mainRegion = "MainRegion";

        /// <summary>
        /// The secondary
        /// </summary>
        private const string secondary = "PoC_WPF.FirstModule.Secondary";

        private List<thing> _sourceList = new List<thing>()
        {
          new thing(){name = "ahah"},
          new thing(){name = "ahah"},
          new thing(){name = "ahah"},
          new thing(){name = "ahah"}
        };

        /// <summary>
        /// Changes this instance.
        /// </summary>
        private void Change()
        {
            this.RegionManager.RegisterViewWithRegion(mainRegion, typeof(Secondary));
            this.RegionManager.RequestNavigate(mainRegion, new Uri(secondary, UriKind.Relative));
        }
    }

    public class thing
    {
        public string name;
    }
}