using shodnyakProga.Services;
using shodnyakProga.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shodnyakProga
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
