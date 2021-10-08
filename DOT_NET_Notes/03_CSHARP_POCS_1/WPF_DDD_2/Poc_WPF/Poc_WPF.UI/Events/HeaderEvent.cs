// -----------------------------------------------------------------------
//  <copyright file="HeaderEvent.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using Prism.Events;

namespace Poc_WPF.UI.Events
{
    /// <summary>
    /// Event for header element.
    /// </summary>
    /// <seealso cref="Prism.Events.PubSubEvent{System.String}" />
    public class HeaderEvent : PubSubEvent<string>
    {
    }
}