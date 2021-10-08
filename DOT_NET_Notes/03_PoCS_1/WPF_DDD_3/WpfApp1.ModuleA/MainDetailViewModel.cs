// -----------------------------------------------------------------------
//  <copyright file="MainDetailViewModel.cs" company="Azure Brain">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace WpfApp1.ModuleA
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using WpfApp1.Core;

    public class MainDetailViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the element.
        /// </summary>
        /// <value>
        /// the element.
        /// </value>
        public string Element { get; set; }

        /// <summary>
        /// Initializes the event.
        /// </summary>
        protected override void InitializeEvent()
        {
            this.EventAggregator.GetEvent<MainElementEvent>().Subscribe(this.ChangeElementAction);
        }

        /// <summary>
        /// Changes the element action.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        private void ChangeElementAction(string element)
        {
            this.Element = element;
        }
    }
}