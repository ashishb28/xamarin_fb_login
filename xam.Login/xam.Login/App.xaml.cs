using System;
using xam.Login.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xam.Login
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SocialLoginPage()); ;
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
