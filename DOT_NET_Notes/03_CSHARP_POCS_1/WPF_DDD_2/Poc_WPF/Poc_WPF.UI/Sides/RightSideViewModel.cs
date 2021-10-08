// -----------------------------------------------------------------------
//  <copyright file="RightSideViewModel.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Poc_WPF.UI.Sides
{
    using Poc_WPF.Core;

    /// <summary>
    /// View model for right side element.
    /// </summary>
    /// <seealso cref="Poc_WPF.Core.ViewModelBase" />
    public class RightSideViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the right side title.
        /// </summary>
        /// <value>
        /// The right side title.
        /// </value>
        public string RightSideTitle { get => _rightSideTitle; set => _rightSideTitle = value; }

        /// <summary>
        /// The right side title
        /// </summary>
        private string _rightSideTitle = "RIGHT SIDE";
    }
}