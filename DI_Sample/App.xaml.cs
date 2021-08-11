﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DI_Sample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Startup.Init();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
