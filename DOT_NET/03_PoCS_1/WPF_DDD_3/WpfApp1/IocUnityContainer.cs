// -----------------------------------------------------------------------
//  <copyright file="BootStrapper.cs" company="Azure Brain">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using Microsoft.Practices.Unity;

namespace WpfApp1
{
    using WpfApp1.ModuleA;

    internal class IocUnityContainer : UnityContainerExtension
    {
        protected override void Initialize()
        {
            //this.Container.RegisterType<IClasseA, ClasseA>(new TransientLifetimeManager());
        }
    }
}