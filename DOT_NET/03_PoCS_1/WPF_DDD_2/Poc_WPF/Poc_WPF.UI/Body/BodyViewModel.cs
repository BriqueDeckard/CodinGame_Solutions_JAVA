// -----------------------------------------------------------------------
//  <copyright file="BodyViewModel.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Poc_WPF.UI.Body
{
    using System;
    using System.Data.Common;
    using System.Xml;
    using Poc_WPF.ApplicationServices.Contracts;
    using Poc_WPF.Domain;
    using Poc_WPF.Infrastructure.Data.UnitOfWork;
    using PropertyChanged;
    using Poc_WPF.Core;
    using Poc_WPF.UI.Events;

    /// <summary>
    /// View model for body element.
    /// </summary>
    /// <seealso cref="Poc_WPF.Core.ViewModelBase" />
    [ImplementPropertyChanged]
    public class BodyViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyViewModel"/> class.
        /// </summary>
        /// <param name="appServices">The application services.</param>
        public BodyViewModel(IEntitiesAppService appServices)
        {
            this._appServices = appServices;
        }

        /// <summary>
        /// Gets or sets the body title.
        /// </summary>
        /// <value>
        /// The body title.
        /// </value>
        public string BodyTitle { get => _bodyTitle; set => _bodyTitle = value; }

        /// <summary>
        /// Initializes the event.
        /// </summary>
        protected override void InitializeEvent()
        {
            base.InitializeEvent();
            this.EventAggregator.GetEvent<HeaderEvent>().Subscribe(this.ReceiveEvent);
        }

        /// <summary>
        /// The application services
        /// </summary>
        private IEntitiesAppService _appServices;

        /// <summary>
        /// The body title
        /// </summary>
        private string _bodyTitle = "BODY";

        /// <summary>
        /// Receives the event.
        /// </summary>
        /// <param name="eventValue">The event value.</param>
        private void ReceiveEvent(string eventValue)
        {
            this.BodyTitle = eventValue;
            var dto = new EntityDto()
            {
                Body = "Ipsum",
                Reference = "00",
                Title = "LOREM"
            };

            var result = this._appServices.Add(dto);

            this.BodyTitle = result.ToString();

            var dot = _appServices.Search("");
        }
    }
}