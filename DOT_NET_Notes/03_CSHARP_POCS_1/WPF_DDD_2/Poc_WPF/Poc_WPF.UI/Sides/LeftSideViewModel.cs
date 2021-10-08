// -----------------------------------------------------------------------
//  <copyright file="LeftSideViewModel.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using System.Collections.ObjectModel;
using Poc_WPF.Core;
using Poc_WPF.Domain;

namespace Poc_WPF.UI.Sides
{
    /// <summary>
    /// View model for left side element.
    /// </summary>
    /// <seealso cref="Poc_WPF.Core.ViewModelBase" />
    public class LeftSideViewModel : ViewModelBase
    {
        public LeftSideViewModel()
        {
            Entities = new ObservableCollection<Entity>();
            Entities.Add(new Entity()
            {
                Body = "BODY",
                reference = "AA",
                Title = "TITLE"
            });
            Entities.Add(new Entity()
            {
                Body = "BODY",
                reference = "AA",
                Title = "TITLE"
            });
            Entities.Add(new Entity()
            {
                Body = "BODY",
                reference = "AA",
                Title = "TITLE"
            });
            Entities.Add(new Entity()
            {
                Body = "BODY",
                reference = "AA",
                Title = "TITLE"
            });
        }

        /// <summary>
        /// Gets or sets the entities.
        /// </summary>
        /// <value>
        /// The entities.
        /// </value>
        public ObservableCollection<Entity> Entities { get; set; }

        /// <summary>
        /// Gets or sets the left side title.
        /// </summary>
        /// <value>
        /// The left side title.
        /// </value>
        public string LeftSideTitle { get => _leftSideTitle; set => _leftSideTitle = value; }

        /// <summary>
        /// The left side title
        /// </summary>
        private string _leftSideTitle = "LEFT SIDE";
    }
}