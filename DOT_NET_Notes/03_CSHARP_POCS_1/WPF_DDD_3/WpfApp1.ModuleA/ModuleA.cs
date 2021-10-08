using Prism.Modularity;

namespace WpfApp1.ModuleA
{
    using Prism.Regions;

    public class ModuleA : IModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleA"/> class.
        /// </summary>
        /// <param name="regionManager">The region manager.</param>
        public ModuleA(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
        }

        /// <summary>
        /// Notifies the module that it has be initialized.
        /// </summary>
        public void Initialize()
        {
            this._regionManager.RegisterViewWithRegion("LeftRegion", typeof(Main));
            this._regionManager.RegisterViewWithRegion("RightRegion", typeof(MainDetail));
        }

        /// <summary>
        /// The region manager
        /// </summary>
        private readonly IRegionManager _regionManager;
    }
}