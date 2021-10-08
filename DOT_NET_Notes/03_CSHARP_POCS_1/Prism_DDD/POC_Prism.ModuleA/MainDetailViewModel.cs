// -----------------------------------------------------------------------
//  <copyright file="MainDetailViewModel.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace POC_Prism.ModuleA
{
    using System.ComponentModel;
    using PropertyChanged;

    using POC_Prism.Core;

    /// <summary>
    /// View Model class for the Main Detail view.
    /// </summary>
    /// <seealso cref="System.ComponentModel.INotifyPropertyChanged" />
    /// <seealso cref="POC_Prism.Core.ViewModelBase" />
    [ImplementPropertyChanged]
    public class MainDetailViewModel : ViewModelBase, INotifyPropertyChanged
    {
        /// <summary>
        /// Se produit en cas de modification d'une valeur de propriété.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets the element.
        /// </summary>
        /// <value>
        /// The element.
        /// </value>
        public string Element { get; set; }

        /// <summary>
        /// Initializes the event.
        /// </summary>
        protected override void InitializeEvent()
        {
            base.InitializeEvent();
            this.EventAggregator.GetEvent<MainElementEvent>().Subscribe(this.ChangedElementAction);
        }

        /// <summary>
        /// The Changed element action .
        /// </summary>
        /// <param name="element">The element.</param>
        private void ChangedElementAction(string element)
        {
            this.Element = element;
        }
    }
}