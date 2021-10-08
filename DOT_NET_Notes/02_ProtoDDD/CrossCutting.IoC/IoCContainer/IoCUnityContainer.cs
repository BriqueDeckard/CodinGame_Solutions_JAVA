using System;
using Prototype.ApplicationServices;
using Prototype.ApplicationServices.Contracts;
using Prototype.Domain.AggregatesModel.SampleEntityAggregate;
using Prototype.Domain.Contracts.Mappers;
using Prototype.Domain.Contracts.SeedWork;
using Prototype.Domain.Mappers;
using Prototype.DomainServices;
using Prototype.DomainServices.Contracts;
using Prototype.Infrastructure.Data.Context;
using Prototype.Infrastructure.Data.repositories;
using Unity;

namespace Prototype.CrossCutting.IoC.IoCContainer
{
    /// <summary>
    ///     Class that handle IoC by using an Unity container.
    /// </summary>
    public static class IoCUnityContainer
    {
        /// <summary>
        ///     Registers the services to inject.
        /// </summary>
        /// <returns></returns>
        public static UnityContainer Register()
        {
            Console.WriteLine("\nIoCUnityContainer : Initialize IoC ... ");
            var container = new UnityContainer();

            Console.WriteLine("IoCUnityContainer : Register UnitOfWork.");
            container.RegisterType<IUnitOfWork, ProtoContext>();

            Console.WriteLine("IoCUnityContainer : Register repository.");
            container.RegisterType<IRepository, GenericRepository>();

            Console.WriteLine("IoCUnityContainer : Register mapper.");
            container.RegisterType<ISampleEntityMapper<SampleEntity>, SampleEntityMapper>();

            Console.WriteLine("IoCUnityContainer : Register domain services.");
            container.RegisterType<ISampleEntityDomainService, SampleEntityDomainService>();

            Console.WriteLine("IoCUnityContainer : Register application services.");
            container.RegisterType<IPrototypeApplicationService, PrototypeApplicationService>();

            Console.WriteLine("IoCUnityContainer : ... IoC Initialized\n");
            //Console.ReadKey();
            return container;
        }
    }
}