// -----------------------------------------------------------------------
//  <copyright file="IoCUnityContainer.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using System.Runtime.CompilerServices;
using PoC_WPF.Domain.Aggregates;

[assembly: InternalsVisibleTo("PoC_WPF")]

namespace PoC_WPF.CrossCutting.IoC
{
    using PoC_WPF.ApplicationServices;
    using PoC_WPF.ApplicationServices.Contracts;
    using PoC_WPF.Domain;
    using PoC_WPF.Infrastructure.Data.Repositories;
    using PoC_WPF.Infrastructure.Data.UnitOfWork;

    using Microsoft.Practices.Unity;

    //TODO : WPF3.1 Create a CrossCutting.IoC library
    //TODO : WPF3.2 Import the Unity NuGet
    //TODO : WPF3.3 Create an IoCUnityContainer that inherits from the UnityContainerExtension class.
    /// <summary>
    /// IoC Unity Container.
    /// </summary>
    /// <seealso cref="Microsoft.Practices.Unity.UnityContainerExtension" />
    internal class IoCUnityContainer : UnityContainerExtension
    {
        //TODO : WPF 6.3 Inject the appservices by using the ioc container
        /// <summary>
        /// Initial the container with this extension's functionality.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        /// <remarks>
        /// When overridden in a derived class, this method will modify the given
        /// <see cref="T:Microsoft.Practices.Unity.ExtensionContext" /> by adding strategies, policies, etc. to
        /// install it's functions into the container.
        /// </remarks>
        protected override void Initialize()
        {
            this.Container.RegisterType<IPocAppService, PocAppService>();
            this.Container.RegisterType<IRepository<EntityClass>, GenericRepository<EntityClass>>();
            this.Container.RegisterType<IUnitOfWork, PoC_Context>();
        }
    }
}