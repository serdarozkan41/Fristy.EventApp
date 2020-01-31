using EventApp.PopupViews;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EventApp.ViewModels.WelcomeViewModels
{
    public class RegisterViewModel : BaseViewModel
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

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }
        private string againPassword;

        public string AgainPassword
        {
            get { return againPassword; }
            set
            {
                againPassword = value;
                OnPropertyChanged();
            }
        }

        private string fullName;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }

        public RegisterViewModel()
        {
            LoginCommand = new Command(OnLogin);
            RegisterCommand = new Command(OnRegister);
        }

        private async void OnRegister()
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
