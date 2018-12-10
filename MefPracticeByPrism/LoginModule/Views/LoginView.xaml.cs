using LoginModule.ViewModels;
using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace LoginModule.Views
{
    /// <summary>
    /// LoginView.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 
    [Export(typeof(LoginView))]
    public partial class LoginView : UserControl
    {
        [Import]
        public LoginViewModel ViewModel
        {
            set { this.DataContext = value; }
        } 




        public LoginView()
        {
            InitializeComponent();
        }
    }
}
