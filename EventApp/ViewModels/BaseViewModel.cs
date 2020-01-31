using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace EventApp.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(
               [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(
                    this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetValue<T>(ref T backingField,
              T value,
              [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(
                         backingField, value)) return;
            backingField = value;
            OnPropertyChanged(propertyName);
        }

        private bool isBusy;

        public bool IsBusy
        {
            get { return isBusy; }
            set { SetValue(ref isBusy, value); }
        }

        public async void GoPage(Page targetPage)
        {
            await Application.Current.MainPage.Navigation.PushAsync(targetPage);
        }

        public async void BackPage()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
