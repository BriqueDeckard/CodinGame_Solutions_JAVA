// -----------------------------------------------------------------------
//  <copyright file="MainWindowViewModel.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Documents;
using PropertyChanged;

namespace POC_Prism
{
    using POC_Prism.Core;
    using POC_Prism.ModuleA;

    using Prism.Commands;

    using System;

    //TODO : 9
    [ImplementPropertyChanged]
    public class MainWindowViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
        /// </summary>
        public MainWindowViewModel()
        {
            this.RegionManager.RequestNavigate("LeftRegion", new Uri("POC_Prism.ModuleA.Main", UriKind.Relative));
            this.RegionManager.RequestNavigate("RightRegion", new Uri("POC_Prism.ModuleA.MainDetail", UriKind.Relative));
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

        /*
        private async <List<string> Results, int count, List<string> errorMessages) GetDatas(string search = "", int? id = null)
        {
            await Task.Delay(10);
            return (new List<string>(), 0, ne;
        }
        */
        /*
        private async ValueTask<List<string>> GetDatas()
        {
            await Task.Delay(10);
            var list = new List<string>();
            return list;
        }
        */

        /// <summary>
        /// Action to navigate.
        /// </summary>
        private void NavigateAction()
        {
            this.RegionManager.RegisterViewWithRegion("RightRegion", typeof(Main));
            //  var result = await this.GetDatas();

            //this.RegionManager.RequestNavigate("RightRegion", new Uri("POC_Prism.ModuleA.Main", UriKind.Relative));
        }
    }
}