using PARCIAL2.VIEWS;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PARCIAL2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ElementoPage();
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
