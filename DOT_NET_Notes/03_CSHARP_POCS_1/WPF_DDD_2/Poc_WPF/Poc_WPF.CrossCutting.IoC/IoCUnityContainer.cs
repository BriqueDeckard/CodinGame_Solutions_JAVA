// -----------------------------------------------------------------------
//  <copyright file="IoCUnityContainer.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Poc_WPF.CrossCutting.IoC
{
    using Poc_WPF.ApplicationServices;
    using Poc_WPF.ApplicationServices.Contracts;
    using Poc_WPF.Domain;
    using Poc_WPF.Infrastructure.Data;

    using Microsoft.Practices.Unity;
    using Poc_WPF.Infrastructure.Data.UnitOfWork;

    /// <summary>
    /// IoC unity container.
    /// </summary>
    /// <seealso cref="Microsoft.Practices.Unity.UnityContainerExtension" />
    public class IoCUnityContainer : UnityContainerExtension
    {
        /// <summary>
        /// Registers the types.
        /// </summary>
        public void RegisterTypes()
        {
            this.Container.RegisterType<IUnitOfWork, Poc_WPFContext>();
            this.Container.RegisterType<IRepository, GenericRepository>();
            this.Container.RegisterType<IFactory, Factory>();
            this.Container.RegisterType<IEntitiesAppService, EntitiesAppService>();
        }

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
            RegisterTypes();
        }
    }
}