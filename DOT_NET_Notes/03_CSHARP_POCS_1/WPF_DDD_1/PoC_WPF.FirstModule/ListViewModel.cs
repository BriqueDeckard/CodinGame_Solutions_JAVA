// -----------------------------------------------------------------------
//  <copyright file="ListViewModel.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using PoC_WPF.Core;
using Prism.Commands;

namespace PoC_WPF.FirstModule
{
    /// <summary>
    /// View Model class for list view.
    /// </summary>
    /// <seealso cref="PoC_WPF.Core.ViewModelBase" />
    public class ListViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the list.
        /// </summary>
        /// <value>
        /// The list.
        /// </value>
        public IList<String> List { get; set; }

        /// <summary>
        /// Gets the list selection changed command.
        /// </summary>
        /// <value>
        /// The list selection changed command.
        /// </value>
        public DelegateCommand ListSelectionChangedCommand => new DelegateCommand(this.SelectionChangedAction);

        /// <summary>
        /// Gets or sets the selected element.
        /// </summary>
        /// <value>
        /// The selected element.
        /// </value>
        public String SelectedElement
        {
            get
            {
                return _selectedElement;
            }
            set
            {
                _selectedElement = value;
            }
        }

        /// <summary>
        /// Initializes the data.
        /// </summary>
        protected override void InitializeData()
        {
            base.InitializeData();
            List = new List<string>()
            {
                "A",
                "B"
            };
        }

        /// <summary>
        /// The detail
        /// </summary>
        private const string detail = "PoC_WPF.FirstModule.Detail";

        /// <summary>
        /// The right region
        /// </summary>
        private const string rightRegion = "right_region";

        private string _selectedElement;

        /// <summary>
        /// Selections the changed action.
        /// </summary>
        private void SelectionChangedAction()
        {
            this.RegionManager.RegisterViewWithRegion(rightRegion, typeof(Detail));
            this.EventAggregator.GetEvent<SelectionEvent>().Publish(this.SelectedElement);
            this.RegionManager.RequestNavigate(rightRegion, new Uri(detail, UriKind.Relative));
        }
    }
}