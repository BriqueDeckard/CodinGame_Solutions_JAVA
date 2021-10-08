// -----------------------------------------------------------------------
//  <copyright file="MainViewModel.cs" company="Azure Brain">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using WpfApp1.Core;

namespace WpfApp1.ModuleA
{
    using Prism.Commands;

    /// <summary>
    /// Main View Model
    /// </summary>
    /// <seealso cref="WpfApp1.Core.ViewModelBase" />
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the selected element.
        /// </summary>
        /// <value>
        /// the selected element.
        /// </value>
        public string SelectedElement { get; set; }

        /// <summary>
        /// Gets the selection changed command.
        /// </summary>
        /// <value>
        /// The selection changed command.
        /// </value>
        public DelegateCommand SelectionChangedCommand => new DelegateCommand(this.SelectionChangedAction);

        protected override void Dispose(bool disposing)
        {
            if (disposing)

            {
                this.SelectedElement = null;
            }

            base.Dispose(disposing);
        }

        /// <summary>
        /// Selections the changed action.
        /// </summary>
        private void SelectionChangedAction()
        {
            this.EventAggregator.GetEvent<MainElementEvent>().Publish(this.SelectedElement);
        }
    }
}