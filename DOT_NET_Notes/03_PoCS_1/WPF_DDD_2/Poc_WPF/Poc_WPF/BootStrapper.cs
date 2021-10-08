// -----------------------------------------------------------------------
//  <copyright file="BootStrapper.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Poc_WPF
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using Poc_WPF.Core;
    using Prism.Mvvm;

    using Poc_WPF.CrossCutting.IoC;
    using Prism.Unity;
    using Microsoft.Practices.Unity;

    /// <summary>
    /// Application bootstrapper.
    /// </summary>
    /// <seealso cref="Prism.Unity.UnityBootstrapper" />
    public class BootStrapper : UnityBootstrapper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BootStrapper"/> class.
        /// </summary>
        public BootStrapper()
        {
        }

        /// <summary>
        /// Configures the <see cref="T:Microsoft.Practices.Unity.IUnityContainer" />. May be overwritten in a derived class to add specific
        /// type mappings required by the application.
        /// </summary>
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            this.Container.AddExtension(new IoCUnityContainer());
        }

        /// <summary>
        /// Configures the <see cref="T:Prism.Mvvm.ViewModelLocator" /> used by Prism.
        /// </summary>
        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.SetDefaultViewModelFactory(
                viewModelType =>
                {
                    if (!(this.Container.Resolve(viewModelType) is ViewModelBase viewModel))
                    {
                        throw new ArgumentException($"This model is not found : {viewModelType.Name}");
                    }

                    //lance initialize sur tous les ViewModel
                    viewModel.Initialize();

                    return viewModel;
                });
        }

        /// <summary>
        /// Creates the shell or main window of the application.
        /// </summary>
        /// <returns>
        /// The shell of the application.
        /// </returns>
        /// <remarks>
        /// If the returned instance is a <see cref="T:System.Windows.DependencyObject" />, the
        /// <see cref="T:Prism.Bootstrapper" /> will attach the default <see cref="T:Prism.Regions.IRegionManager" /> of
        /// the application in its <see cref="F:Prism.Regions.RegionManager.RegionManagerProperty" /> attached property
        /// in order to be able to add regions by using the <see cref="F:Prism.Regions.RegionManager.RegionNameProperty" />
        /// attached property from XAML.
        /// </remarks>
        protected override DependencyObject CreateShell()
        {
            return this.Container.Resolve<MainWindow>();
        }

        /// <summary>
        /// Initializes the modules. May be overwritten in a derived class to use a custom Modules Catalog
        /// </summary>
        protected override void InitializeModules()
        {
            base.InitializeModules();

            Window mainWindow = Application.Current.MainWindow;
            if (mainWindow == null)
            {
                return;
            }

            mainWindow.Show();
            mainWindow.Activate();
            mainWindow.Focus();
        }

        /// <summary>
        /// Initializes the shell.
        /// </summary>
        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (MainWindow)this.Shell;
        }
    }
}