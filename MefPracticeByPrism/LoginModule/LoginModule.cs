namespace LoginModule
{
    using Prism.Modularity;
    using Prism.Regions;
    using Prism.Mef;
    using System.ComponentModel.Composition;
    using Prism.Mef.Modularity;

    [ModuleExport(typeof(LoginModule))]
    public class LoginModule : IModule
    {
        private readonly IRegionManager regionManager;

        [ImportingConstructor]
        public LoginModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        public void Initialize()
        {
            this.regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.LoginView));
        }
    }
}
