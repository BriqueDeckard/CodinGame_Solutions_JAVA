// -----------------------------------------------------------------------
//  <copyright file="FooterViewModel.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using Poc_WPF.Core;

namespace Poc_WPF.UI.Footer
{
    /// <summary>
    /// ViewModel class for footer element.
    /// </summary>
    /// <seealso cref="Poc_WPF.Core.ViewModelBase" />
    public class FooterViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the body title.
        /// </summary>
        /// <value>
        /// The body title.
        /// </value>
        public string FooterTitle { get => _footerTitle; set => _footerTitle = value; }

        /// <summary>
        /// The body title
        /// </summary>
        private string _footerTitle = "FOOTER";
    }
}