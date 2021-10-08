// -----------------------------------------------------------------------
//  <copyright file="BootStrapper.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using POC_Prism.Domain;

namespace POC_Prism.CrossCutting.IoC
{
    using Microsoft.Practices.Unity;
    using POC_Prism.ApplicationService;
    using POC_Prism.ApplicationService.Contract;
    using POC_Prism.Infrastructure.data.Repositories;
    using POC_Prism.Infrastructure.data.UnitOfWork;

    //TODO : 2
    /// <summary>
    /// </summary>
    /// <seealso cref="Microsoft.Practices.Unity.UnityContainerExtension" />
    public class IoCUnityContainer : UnityContainerExtension
    {
        /// <summary>
        /// Initial the container with this extension's functionality.
        /// </summary>
        /// <remarks>
        /// When overridden in a derived class, this method will modify the given
        /// <see cref="T:Microsoft.Practices.Unity.ExtensionContext" /> by adding strategies, policies, etc. to
        /// install it's functions into the container.
        /// </remarks>
        protected override void Initialize()
        {
            // this.Container.RegisterType<IClasseA, ClasseA>( /* LifeTimeManager */);

            // this.Container.RegisterType<MainWindow, MainWindow>(new TransientLifetimeManager());
            //  this.Container.RegisterType<MainWindow, MainWindow>(new TransientLifetimeManager());

            // App services registering
            this.Container.RegisterType<IProductAppService, ProductAppService>();
            this.Container.RegisterType<IUnitOfWork, POC_PrismContext>();
            this.Container.RegisterType<IRepository, GenericRepository>();
        }
    }
}