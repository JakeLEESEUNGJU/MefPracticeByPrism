

namespace StateInfoModule.Views
{
    using global::StateInfoModule.ViewModels;
    using System.ComponentModel.Composition;
    using System.Windows.Controls;

    [Export("StateInfoView")]
    public partial class StateInfoView : UserControl
    {
        [Import]
        public StateInfoModel ViewModel
        {
            set { this.DataContext = value; }
        }

        public StateInfoView()
        {
            InitializeComponent();
        }

    }
}
