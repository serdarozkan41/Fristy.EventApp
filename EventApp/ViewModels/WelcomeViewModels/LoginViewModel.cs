﻿using EventApp.PopupViews;
using EventApp.Views.WelcomeViews;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EventApp.ViewModels.WelcomeViewModels
{
    public class LoginViewModel: BaseViewModel
    {
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value;
                OnPropertyChanged();
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value;
                OnPropertyChanged();
            }
        }



        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }
        public ICommand ForgotCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLogin);
            RegisterCommand = new Command(OnRegister);
            ForgotCommand = new Command(OnForgot);
        }


        private async void OnForgot()
        {
            IsBusy = true;
            try
            {
                GoPage(new ForgotPasswordView());
            }
            catch (Exception ex)
            {
                await Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(new OoopsPopupView(ex.Message));
            }
            IsBusy = false;
        }

        private async void OnRegister()
        {
            IsBusy = true;
            try
            {
                GoPage(new RegisterView());
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
                await Task.Delay(2000);
            }
            catch (Exception ex)
            {
                await Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(new OoopsPopupView(ex.Message));
            }
            IsBusy = false;
        }
    }
}
