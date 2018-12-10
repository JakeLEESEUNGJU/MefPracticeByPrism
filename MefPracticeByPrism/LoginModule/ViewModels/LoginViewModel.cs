using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
#region
namespace LoginModule.ViewModels
{
    [Export]
    public class LoginViewModel : BindableBase
    {
        [Import]
        public IRegionManager regionManager;

        private static Uri stateBGViewUri = new Uri("StateBGView", UriKind.Relative);
        private static Uri stateInfoViewUri = new Uri("StateInfoView", UriKind.Relative);

        public LoginViewModel()
        {
            LoginCommand = new DelegateCommand(DoLogin);
        }

        private void DoLogin()
        {
            this.regionManager.RequestNavigate("MainRegion", stateBGViewUri);
            this.regionManager.RequestNavigate("ContentRegion", stateInfoViewUri);
        }

        public DelegateCommand LoginCommand { get; private set; }
    }
}
#endregion