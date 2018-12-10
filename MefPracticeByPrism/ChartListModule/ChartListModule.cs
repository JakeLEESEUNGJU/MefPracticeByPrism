using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartListModule
{   
    [ModuleExport(typeof(ChartListModule))]
    public class ChartListModule : IModule
    {
        private IRegionManager regionManager;

        [ImportingConstructor]
        public ChartListModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("StateRegion", typeof(Views.ChartListViewModel));
        }
    }
}
