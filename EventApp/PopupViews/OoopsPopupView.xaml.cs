using Rg.Plugins.Popup.Pages;
using Xamarin.Forms.Xaml;

namespace EventApp.PopupViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OoopsPopupView : PopupPage
    {
        public OoopsPopupView(string message)
        {
            InitializeComponent();
            LbMessage.Text = message;
        }

        private async void BuOk_Clicked(object sender, System.EventArgs e)
        {
            await Rg.Plugins.Popup.Services.PopupNavigation.Instance.PopAsync();
        }
    }
}