using Infrastructure;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System.ComponentModel.Composition;

namespace ChartListModule.Views
{
    [Export]
    public class ChartListViewModel : BindableBase
    {
        [Import]
        public IRegionManager regionManager;
        private IEventAggregator eventAggregator;

        private ISendConnect sendConnect;
        public ConnectCheck connectCheck = new ConnectCheck();
    }
}
