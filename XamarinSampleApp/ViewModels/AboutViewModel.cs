﻿using System.Windows.Input;

namespace XamarinSampleApp
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Plugin.Share.CrossShare.Current.OpenBrowser("https://xamarin.com/platform"));
        }

        public ICommand OpenWebCommand { get; }
    }
}
