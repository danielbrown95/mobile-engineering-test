using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using testapp.Core.ViewModels.Home;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testapp.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail, NoHistory = true)]
    public partial class HomePage : MvxContentPage<HomeViewModel>
    {
        public HomePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (Application.Current.MainPage is NavigationPage navigationPage)
            {
                navigationPage.BarTextColor = Color.White;
                navigationPage.BarBackgroundColor = (Color)Application.Current.Resources["Plum"];
                
                var Picker = new Picker { Title = "For Sale or To Let", TitleColor = Color.Purple };
                picker.Items.Add("For Sale");
                picker.Items.Add("To Let");
                
                var propertystatusLabel = new Label();
                propertystatusLabel.SetBinding(Label.TextProperty, new Binding("SelectedItem", source: picker));

                void OnPickerSelectedIndexChanged(object sender, System.EventArgs e)
                {
                    var picker = (Picker)sender;
                    int selectedIndex = picker.SelectedIndex;

                    if (selectedIndex != -1)
                    {
                        propertystatusLabel.Text = (string)picker.ItemsSource[selectedIndex];
                    }
                }
            }
        }
    }
}
