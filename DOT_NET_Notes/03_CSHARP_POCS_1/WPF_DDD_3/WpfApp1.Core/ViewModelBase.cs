namespace WpfApp1.Core
{
    using System;
    using Microsoft.Practices.ServiceLocation;

    using Prism.Events;
    using Prism.Regions;

    using PropertyChanged;

    [ImplementPropertyChanged]
    public abstract class ViewModelBase : IDisposable
    {
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public void Initialize()
        {
            this.InitializeEvent();
            this.InitializeCommand();
            this.InitializeData();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelBase"/> class.
        /// </summary>
        protected ViewModelBase()
        {
            this.EventAggregator = ServiceLocator.Current.TryResolve<IEventAggregator>();
            this.RegionManager = ServiceLocator.Current.TryResolve<IRegionManager>();
        }

        /// <summary>
        /// Gets the event aggregator.
        /// </summary>
        /// <value>
        /// The event aggregator.
        /// </value>
        protected IEventAggregator EventAggregator { get; private set; }

        /// <summary>
        /// Gets the region manager.
        /// </summary>
        /// <value>
        /// The Region Manager
        /// </value>
        protected IRegionManager RegionManager { get; private set; }

        /// <summary>
        /// Initializes the command.
        /// </summary>
        protected virtual void InitializeCommand()
        { }

        /// <summary>
        /// Initializes the data.
        /// </summary>
        protected virtual void InitializeData()
        { }

        /// <summary>
        /// Initializes the event.
        /// </summary>
        protected virtual void InitializeEvent()
        { }

        #region IDisposable Support

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        private bool disposedValue = false; // To detect redundant calls
        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~ViewModelBase() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        #endregion
    }
}