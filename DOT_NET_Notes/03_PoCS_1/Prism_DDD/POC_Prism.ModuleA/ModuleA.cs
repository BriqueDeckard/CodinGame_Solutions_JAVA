namespace POC_Prism.ModuleA
{
    using Prism.Modularity;
    using Prism.Regions;

    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Prism.Modularity.IModule" />
    public class ModuleA : IModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleA"/> class.
        /// </summary>
        /// <param name="regionManager">
        ///     The region manager.
        /// </param>
        public ModuleA(IRegionManager regionManager)
        {
            //TODO: 3
            this._regionManager = regionManager;
        }

        /// <summary>
        /// Notifies the module that it has be initialized.
        /// </summary>
        public void Initialize()
        {
            //TODO : 4
            this._regionManager.RegisterViewWithRegion(l_region, typeof(Main));
            this._regionManager.RegisterViewWithRegion(r_region, typeof(MainDetail));
        }

        /// <summary>
        /// The region
        /// </summary>
        private const string l_region = "LeftRegion";

        private const string r_region = "RightRegion";

        /// <summary>
        /// The region manager
        /// </summary>
        private readonly IRegionManager _regionManager;
    }
}