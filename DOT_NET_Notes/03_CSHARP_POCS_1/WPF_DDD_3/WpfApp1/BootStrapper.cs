// -----------------------------------------------------------------------
//  <copyright file="BootStrapper.cs" company="Azure Brain">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Windows;

    using Microsoft.Practices.Unity;

    using Prism.Modularity;
    using Prism.Mvvm;
    using Prism.Unity;

    using WpfApp1.Core;

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
            this.Container.AddExtension(new IocUnityContainer());
        }

        /// <summary>
        /// Configures the <see cref="T:Prism.Modularity.IModuleCatalog" /> used by Prism.
        /// </summary>
        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            this.ModuleCatalog.AddModule(new ModuleInfo()
            {
                InitializationMode = InitializationMode.WhenAvailable,
                ModuleName = typeof(ModuleA.ModuleA).Name,
                ModuleType = typeof(ModuleA.ModuleA).AssemblyQualifiedName
            });
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
                             throw new ArgumentException($"this model isn't found : {viewModelType.Name}");
                         }

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
            var mainWindows = Application.Current.MainWindow;

            if (mainWindows == null)
            {
                return;
            }

            mainWindows.Show();
            mainWindows.Activate();
            mainWindows.Focus();
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