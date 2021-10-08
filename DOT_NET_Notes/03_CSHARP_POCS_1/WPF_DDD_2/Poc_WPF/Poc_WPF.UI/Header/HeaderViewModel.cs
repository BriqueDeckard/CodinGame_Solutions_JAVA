// -----------------------------------------------------------------------
//  <copyright file="HeaderViewModel.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using System.Runtime.Remoting.Messaging;
using Poc_WPF.Core;
using Poc_WPF.UI.Events;
using Prism.Commands;

namespace Poc_WPF.UI.Header
{
    public class HeaderViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HeaderViewModel"/> class.
        /// </summary>
        public HeaderViewModel()
        {
            _headerTitle = "HEADER";
            strValue = "Changed";
        }

        /// <summary>
        /// Gets or sets the body title.
        /// </summary>
        /// <value>
        /// The body title.
        /// </value>
        public string HeaderTitle { get => _headerTitle; set => _headerTitle = value; }

        /// <summary>
        /// The send event command
        /// </summary>
        public DelegateCommand SendEventCommand => new DelegateCommand(this.DoSend);

        /// <summary>
        /// Sends the event.
        /// </summary>
        public void DoSend()
        {
            this.EventAggregator.GetEvent<HeaderEvent>().Publish(this.strValue);
        }

        /// <summary>
        /// The body title
        /// </summary>
        private string _headerTitle;

        /// <summary>
        /// The string value
        /// </summary>
        private string strValue;
    }
}