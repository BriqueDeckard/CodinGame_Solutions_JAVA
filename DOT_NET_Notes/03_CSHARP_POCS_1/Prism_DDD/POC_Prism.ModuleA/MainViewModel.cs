// -----------------------------------------------------------------------
//  <copyright file="MainViewModel.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace POC_Prism.ModuleA
{
    using System.Collections.Generic;
    using Microsoft.Practices.ServiceLocation;
    using POC_Prism.ApplicationService.Contract;
    using POC_Prism.Core;
    using Prism.Commands;
    using PropertyChanged;

    /// <summary>
    /// View model class for the main view.
    /// </summary>
    /// <seealso cref="POC_Prism.Core.ViewModelBase" />
    [ImplementPropertyChanged]
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the product search dtos.
        /// </summary>
        /// <value>
        /// The product search dtos.
        /// </value>
        public IList<ProductSearchDto> ProductSearchDtos { get; set; }

        /// <summary>
        /// Gets or sets the search text.
        /// </summary>
        /// <value>
        /// The search text.
        /// </value>
        public string SearchText { get; set; } = "";

        /// <summary>
        /// Gets or sets the selected element.
        /// </summary>
        /// <value>
        /// The selected element.
        /// </value>
        public string SelectedElement { get; set; }

        /// <summary>
        /// Gets the selection changed command.
        /// </summary>
        /// <value>
        /// The selection changed command.
        /// </value>
        public DelegateCommand SelectionChangedCommand => new DelegateCommand(this.SelectionChangedAction);

        /// <summary>
        /// Initializes the data.
        /// </summary>
        protected override void InitializeData()
        {
            IProductAppService service = ServiceLocator.Current.GetInstance<IProductAppService>();

            //  IList<ProductSearchDto> result = service.Search(this.SearchText);

            this.ProductSearchDtos = service.Search(this.SearchText);
        }

        /// <summary>
        /// Action for changed selection.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        private void SelectionChangedAction()
        {
            this.EventAggregator.GetEvent<MainElementEvent>().Publish(this.SelectedElement);
        }
    }
}