using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EcoTaxi.Class;

namespace EcoTaxi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            



        }

        protected override void OnStart()
        {
            MainPage = new MainPage();

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
