using EventApp.PopupViews;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EventApp.ViewModels.WelcomeViewModels
{
    public class ForgotPasswordViewModel : BaseViewModel
    {
        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand { get; set; }
        public ICommand ForgotCommand { get; set; }

        public ForgotPasswordViewModel()
        {
            LoginCommand = new Command(OnLogin);
            ForgotCommand = new Command(OnForgot);
        }

        private async void OnForgot()
        {
            IsBusy = true;
            try
            {
                await Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(new OoopsPopupView("mail or password is incorrect"));
            }
            catch (Exception ex)
            {
                await Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(new OoopsPopupView(ex.Message));
            }
            IsBusy = false;
        }

        private async void OnLogin()
        {
            IsBusy = true;
            try
            {
                BackPage();
            }
            catch (Exception ex)
            {
                await Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(new OoopsPopupView(ex.Message));
            }
            IsBusy = false;
        }
    }
}
