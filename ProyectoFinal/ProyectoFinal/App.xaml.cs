using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProyectoFinal.Views;

namespace ProyectoFinal
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            // Autenticacion
            Properties["IsLoggedIn"] = false;

            MainPage = new MainPage();
           
           

        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

