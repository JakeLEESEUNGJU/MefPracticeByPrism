using Infrastructure;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateInfoModule.ViewModels
{
    [Export]
    public class StateInfoModel : BindableBase
    {

        [Import]
        public IRegionManager regionManager;

        public DelegateCommand ImageCommand { get; private set; }
        public DelegateCommand TextCommand { get; private set; }

        private string ConnectionColor = "#00FF00";
        private string DisconnectionColor = "#FF0000";

        private static Uri imageUri = new Uri("ImageListModuleVIew", UriKind.Relative);
        private static Uri textUri = new Uri("ChartListModuleView", UriKind.Relative);

        private string imageConnectColor = "#00FF00";
        public string textConnectColor = "#00FF00";
        public string ImageConnectColor
        {
            get { return imageConnectColor; }
            set { SetProperty(ref imageConnectColor, value); }
        }
        public string TextConnectColor
        {
            get { return textConnectColor; }
            set { SetProperty(ref textConnectColor, value); }
        }

        private IEventAggregator eventAggregator;

        [ImportingConstructor]
        public StateInfoModel(IEventAggregator aggregator)
        {
            ImageCommand = new DelegateCommand(GoImage);
            TextCommand = new DelegateCommand(GoText);

            this.eventAggregator = aggregator;
            eventAggregator.GetEvent<ConnectAddedEvent>().Subscribe(ConnectAddedEventHandler, ThreadOption.BackgroundThread);
        }

        private void GoText()
        {
            this.regionManager.RequestNavigate("ContentRegion", textUri);
        }

        private void GoImage()
        {
            this.regionManager.RequestNavigate("ContentRegion", imageUri);
        }

        public void ConnectAddedEventHandler(ConnectCheck connectCheck)
        {
            switch (connectCheck.RadioID)
            {
                case "ImageModule":
                    ImageConnectColor = connectCheck.ConnetedIsCheck == ConnectionState.Connected ? ConnectionColor : DisconnectionColor;
                    break;
                case "ChartModule":
                    TextConnectColor = connectCheck.ConnetedIsCheck == ConnectionState.Connected ? ConnectionColor : DisconnectionColor;
                    break;
            }
        }

    }
}
