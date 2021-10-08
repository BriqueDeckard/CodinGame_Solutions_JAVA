// -----------------------------------------------------------------------
//  <copyright file="Bootstrapper.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Practices.Unity;
using PoC_WPF.Core;
using PoC_WPF.CrossCutting.IoC;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Unity;

namespace PoC_WPF
{
    //TODO : WPF1 Create a bootstrapper class.
    //TODO : WPF2 Import PrismUnity 6.3.0 NuGet, and make the bootstrapper class inherits from UnityBootstrapper.
    /// <summary>
    /// Bootstrapper class for the app.
    /// </summary>
    public class Bootstrapper : UnityBootstrapper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bootstrapper"/> class.
        /// </summary>
        public Bootstrapper()
        {
        }

        //TODO : WPF3.5 Configure containers.
        /// <summary>
        /// Configures the <see cref="T:Microsoft.Practices.Unity.IUnityContainer" />. May be overwritten in a derived class to add specific
        /// type mappings required by the application.
        /// </summary>
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            this.Container.AddExtension(new IoCUnityContainer());
        }

        //TODO : WPF3.6 Configure modules.
        /// <summary>
        /// Configures the <see cref="T:Prism.Modularity.IModuleCatalog" /> used by Prism.
        /// </summary>
        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            this.ModuleCatalog.AddModule(
                new ModuleInfo()
                {
                    InitializationMode = InitializationMode.WhenAvailable,
                    ModuleName = typeof(FirstModule.FirstModule).Name,
                    ModuleType = typeof(FirstModule.FirstModule).AssemblyQualifiedName
                });
        }

        /// <summary>
        /// Configures the <see cref="T:Prism.Mvvm.ViewModelLocator" /> used by Prism.
        /// </summary>
        protected override void ConfigureViewModelLocator()
        {
            // TODO: 5
            base.ConfigureViewModelLocator();

            //methode pour la resolution des view model, utilisée uniquement ici
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

        //TODO : WPF3.13 Create shell
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

        //TODO : WPF3.15 Initialize modules.
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

        //TODO : WPF3.14 Initialize shell
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