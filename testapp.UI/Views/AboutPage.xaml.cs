using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using testapp.Core.ViewModels.About;
using Xamarin.Forms.Xaml;

namespace testapp.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail, NoHistory = true)]
    public partial class AboutPage : MvxContentPage<AboutViewModel>
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        
        // Objective 1 - Allow visiting Purplebricks website from About Screen //
        
        private void OnButtonClicked(object sender, System.EventArgs args)
        {
            Xamarin.Forms.Device.OpenUri(new System.Uri("http://www.purplebricks.com"));
        }
    }
}
