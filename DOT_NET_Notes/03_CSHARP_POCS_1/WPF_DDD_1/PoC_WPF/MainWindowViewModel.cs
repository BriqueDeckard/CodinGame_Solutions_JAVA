// -----------------------------------------------------------------------
//  <copyright file="MainWindowViewModel.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>

namespace PoC_WPF
{
    using PoC_WPF.Core;
    using System;
    using PoC_WPF.ApplicationServices;
    using PoC_WPF.ApplicationServices.Contracts;
    using PoC_WPF.CrossCutting.IoC;
    using PoC_WPF.Domain.Aggregates;
    using PoC_WPF.FirstModule;
    using Prism.Commands;
    using Prism.Unity;

    //TODO : WPF 4 Create the MainWindow ViewModel
    /// <summary>
    /// ViewModel class for MainWindow.
    /// </summary>
    /// <seealso cref="PoC_WPF.Core.ViewModelBase" />
    public class MainWindowViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowViewModel" /> class.
        /// </summary>
        public MainWindowViewModel(IPocAppService pocAppService)
        {
            // Attributes the FirstModuleMain to the Main Region
            this.RegionManager.RequestNavigate(mainRegion, new Uri("PoC_WPF.FirstModule.Main", UriKind.Relative));
            this._pocAppService = pocAppService;
        }

        /// <summary>
        /// Gets the add command.
        /// </summary>
        /// <value>
        /// The add command.
        /// </value>
        public DelegateCommand AddCommand => new DelegateCommand(this.AddAction);

        /// <summary>
        /// Gets the get command.
        /// </summary>
        /// <value>
        /// The get command.
        /// </value>
        public DelegateCommand GetCommand => new DelegateCommand(this.GetAction);

        /// <summary>
        /// Gets the name of the item.
        /// </summary>
        /// <value>
        /// The name of the item.
        /// </value>
        public string ItemName { get; set; }

        /// <summary>
        /// Gets the pto s command.
        /// </summary>
        /// <value>
        /// The pto s command.
        /// </value>
        public DelegateCommand PtoSCommand => new DelegateCommand(this.PrimaryToSecondary);

        /// <summary>
        /// Gets the change command.
        /// </summary>
        /// <value>
        /// The change command.
        /// </value>
        public DelegateCommand ResetCommand => new DelegateCommand(this.Reset);

        /// <summary>
        /// Gets the sto p command.
        /// </summary>
        /// <value>
        /// The sto p command.
        /// </value>
        public DelegateCommand StoPCommand => new DelegateCommand(this.SecondaryToPrimary);

        /// <summary>
        /// The detail
        /// </summary>
        private const string detail = "PoC_WPF.FirstModule.Detail";

        /// <summary>
        /// The empty
        /// </summary>
        private const string empty = "PoC_WPF.FirstModule.Empty";

        /// <summary>
        /// The left region
        /// </summary>
        private const string leftRegion = "left_region";

        private const string list = "PoC_WPF.FirstModule.List";
        private const string main = "PoC_WPF.FirstModule.Main";

        /// <summary>
        /// The main region
        /// </summary>
        private const string mainRegion = "MainRegion";

        /// <summary>
        /// The primary
        /// </summary>
        private const string primary = "PoC_WPF.FirstModule.Main";

        /// <summary>
        /// The right region
        /// </summary>
        private const string rightRegion = "right_region";

        /// <summary>
        /// The secondary
        /// </summary>
        private const string secondary = "PoC_WPF.FirstModule.Secondary";

        /// <summary>
        /// The secondary region
        /// </summary>
        private const string secondaryRegion = "SecondaryRegion";

        /// <summary>
        /// The application service
        /// </summary>
        private IPocAppService _pocAppService;

        /// <summary>
        /// Adds the action.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void AddAction()
        {
            var test = this._pocAppService.Add();
            Console.WriteLine(test);
        }

        /// <summary>
        /// Gets the action.
        /// </summary>
        private void GetAction()
        {
            EntityClass test = this._pocAppService.Get(03);
            ItemName = test.Name;
        }

        /// <summary>
        /// Primaries to secondary.
        /// </summary>
        private void PrimaryToSecondary()
        {
            this.RegionManager.RegisterViewWithRegion(leftRegion, typeof(Main));
            this.RegionManager.RequestNavigate(leftRegion, new Uri(main, UriKind.Relative));
        }

        /// <summary>
        /// Changes the action.
        /// </summary>
        private void Reset()
        {
            this.RegionManager.RegisterViewWithRegion(mainRegion, typeof(Empty));
            this.RegionManager.RequestNavigate(mainRegion, empty);
            this.RegionManager.RegisterViewWithRegion(leftRegion, typeof(Empty));
            this.RegionManager.RequestNavigate(leftRegion, empty);
            this.RegionManager.RegisterViewWithRegion(rightRegion, typeof(Empty));
            this.RegionManager.RequestNavigate(rightRegion, empty);
        }

        /// <summary>
        /// Secondaries to primary.
        /// </summary>
        private void SecondaryToPrimary()
        {
            this.RegionManager.RegisterViewWithRegion("right_region", typeof(Detail));
            this.RegionManager.RequestNavigate("right_region", new Uri(detail, UriKind.Relative));
        }
    }
}