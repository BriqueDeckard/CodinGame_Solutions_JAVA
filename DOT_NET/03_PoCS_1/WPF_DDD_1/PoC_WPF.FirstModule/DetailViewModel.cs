// -----------------------------------------------------------------------
//  <copyright file="DetailViewModel.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace PoC_WPF.FirstModule
{
    using System;
    using Prism.Commands;
    using PropertyChanged;

    using PoC_WPF.Core;

    /// <summary>
    /// ViewModel class for Detail view.
    /// </summary>
    /// <seealso cref="PoC_WPF.Core.ViewModelBase" />
    public class DetailViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the received element.
        /// </summary>
        /// <value>
        /// The received element.
        /// </value>
        public string ReceivedElement
        {
            get => _receivedElement;
            set
            {
                _receivedElement = value;
            }
        }

        /// <summary>
        /// Gets the reset command.
        /// </summary>
        /// <value>
        /// The reset command.
        /// </value>
        public DelegateCommand ResetCommand => new DelegateCommand(this.ResetAction);

        /// <summary>
        /// Initializes the event.
        /// </summary>
        protected override void InitializeEvent()
        {
            base.InitializeEvent();
            this.EventAggregator.GetEvent<SelectionEvent>().Subscribe(this.ReceivedElementAction);
        }

        /// <summary>
        /// The main region
        /// </summary>
        private const string mainRegion = "MainRegion";

        /// <summary>
        /// The primary
        /// </summary>
        private const string primary = "PoC_WPF.FirstModule.Main";

        /// <summary>
        /// The received element
        /// </summary>
        private string _receivedElement;

        /// <summary>
        /// Receiveds the element action.
        /// </summary>
        /// <param name="element">The element.</param>
        private void ReceivedElementAction(string element)
        {
            this.ReceivedElement = element;
        }

        /// <summary>
        /// Resets the action.
        /// </summary>
        private void ResetAction()
        {
            this.RegionManager.RegisterViewWithRegion(mainRegion, typeof(Main));
            this.RegionManager.RequestNavigate(mainRegion, new Uri(primary, UriKind.Relative));
        }
    }
}