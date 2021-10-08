// -----------------------------------------------------------------------
//  <copyright file="ViewModelBase.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using System;
using PropertyChanged;

namespace Poc_WPF.Core
{
    /// <summary>
    /// View model base for the application.
    /// TODO : 1 - Start here.
    /// TODO : Add Nugets :
    /// TODO : - CommonServiceLocator
    /// TODO : - Prism.Core
    /// TODO : - Prism.Wpf
    /// TODO : - PropertyChanged.Fody

    /// TODO : Add   [ImplementPropertyChanged] attribute.
    /// TODO : Implement IDisposable and Dispose mdethod.
    ///
    /// </summary>
    [ImplementPropertyChanged]
    public abstract class ViewModelBase : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}