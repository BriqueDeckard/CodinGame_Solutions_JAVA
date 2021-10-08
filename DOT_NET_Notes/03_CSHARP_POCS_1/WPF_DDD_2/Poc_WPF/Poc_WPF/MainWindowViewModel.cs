// -----------------------------------------------------------------------
//  <copyright file="MainWindowViewModel.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using System;
using Poc_WPF.Core;
using Poc_WPF.UI.Body;
using Poc_WPF.UI.Footer;
using Poc_WPF.UI.Header;
using Poc_WPF.UI.Sides;

namespace Poc_WPF
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Poc_WPF.Core.ViewModelBase" />
    public class MainWindowViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
        /// </summary>
        public MainWindowViewModel()
        {
            RegisterRegion();
            InitializeView();
        }

        /// <summary>
        /// Initializes the view.
        /// </summary>
        public void InitializeView()
        {
            this.RegionManager.RequestNavigate(header_region_name, new Uri(header_URI, UriKind.Relative));
            this.RegionManager.RequestNavigate(footer_region_name, new Uri(footer_URI, UriKind.Relative));
            this.RegionManager.RequestNavigate(main_region_name, new Uri(body_URI, UriKind.Relative));
            this.RegionManager.RequestNavigate(left_region_name, new Uri(leftside_URI, UriKind.Relative));
            this.RegionManager.RequestNavigate(right_region_name, new Uri(rightside_URI, UriKind.Relative));
        }

        /// <summary>
        /// Registers the region.
        /// </summary>
        public void RegisterRegion()
        {
            this.RegionManager.RegisterViewWithRegion(header_region_name, typeof(Header));
            this.RegionManager.RegisterViewWithRegion(footer_region_name, typeof(Footer));
            this.RegionManager.RegisterViewWithRegion(main_region_name, typeof(Body));
            this.RegionManager.RegisterViewWithRegion(left_region_name, typeof(LeftSide));
            this.RegionManager.RegisterViewWithRegion(right_region_name, typeof(RightSide));
        }

        /// <summary>
        /// The body URI
        /// </summary>
        private const string body_URI = "Poc_WPF.UI.Body";

        /// <summary>
        /// The footer region name
        /// </summary>
        private const string footer_region_name = "FooterRegion";

        /// <summary>
        /// The footer URI
        /// </summary>
        private const string footer_URI = "Poc_WPF.UI.Footer";

        /// <summary>
        /// The header region name
        /// </summary>
        private const string header_region_name = "HeaderRegion";

        /// <summary>
        /// The header URI
        /// </summary>
        private const string header_URI = "Poc_WPF.UI.Header";

        /// <summary>
        /// The left region name
        /// </summary>
        private const string left_region_name = "LeftRegion";

        /// <summary>
        /// The sides URI
        /// </summary>
        private const string leftside_URI = "Poc_WPF.UI.Sides.LeftSide";

        /// <summary>
        /// The main region name
        /// </summary>
        private const string main_region_name = "MainRegion";

        /// <summary>
        /// The right region name
        /// </summary>
        private const string right_region_name = "RightRegion";

        /// <summary>
        /// The rightside URI
        /// </summary>
        private const string rightside_URI = "Poc_WPF.UI.Sides.RightSide";
    }
}