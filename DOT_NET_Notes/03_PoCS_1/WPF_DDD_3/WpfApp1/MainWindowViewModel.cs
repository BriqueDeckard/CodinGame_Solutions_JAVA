// -----------------------------------------------------------------------
//  <copyright file="MainWindowsViewModel.cs" company="Azure Brain">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace WpfApp1
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Prism.Commands;

    using WpfApp1.Core;
    using WpfApp1.ModuleA;

    public class MainWindowViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
        /// </summary>
        public MainWindowViewModel()
        {
        }

        /// <summary>
        /// Gets the navigate command.
        /// </summary>
        /// <value>
        /// The navigate command.
        /// </value>
        public DelegateCommand NavigateCommand => new DelegateCommand(this.NavigateAction);

        /// <summary>
        /// Initializes the data.
        /// </summary>
        protected override void InitializeData()
        {
        }

        /// <summary>
        /// Gets the datas.
        /// </summary>
        /// <param name="search">The search.</param>
        /// <returns>
        /// Results = List Element,
        /// Count = nombre d'element
        /// </returns>
        private async Task<(List<string> Results, int Count, List<string> ErrorsMessages)> GetDatas(string search = "", int? id = null)
        {
            await Task.Delay(10);
            return (new List<string>(), 0, new List<string>());
        }

        /// <summary>
        /// Navigates the action.
        /// </summary>
        private void NavigateAction()
        {
            this.RegionManager.RegisterViewWithRegion("RightRegion", typeof(Main));
            var result = this.GetDatas(id: 12);
            //this.RegionManager.RequestNavigate("RightRegion", new Uri("WpfApp1.ModuleA.Main", UriKind.Relative));
        }
    }
}