using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using System.ComponentModel.Composition;

namespace StateInfoModule
{
    [ModuleExport(typeof(StateInfoModule))]
    public class StateInfoModule : IModule
    {

        private readonly IRegionManager regionManager;

        [ImportingConstructor]
        public StateInfoModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {

        }

      
    }
}