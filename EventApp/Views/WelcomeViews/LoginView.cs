﻿using System;

using Xamarin.Forms;

namespace EventApp.Views.WelcomeViews
{
    public class LoginView : ContentPage
    {
        public LoginView()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

