// -----------------------------------------------------------------------
//  <copyright file="MainElementEvent.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------
namespace POC_Prism.ModuleA
{
    using Prism.Events;

    /// <summary>
    /// Event for main element.
    /// </summary>
    /// <seealso cref="Prism.Events.PubSubEvent{System.String}" />
    public class MainElementEvent : PubSubEvent<string>
    {
    }
}