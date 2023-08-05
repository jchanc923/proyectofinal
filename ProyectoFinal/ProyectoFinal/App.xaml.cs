﻿using System;
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

            MainPage = new PageRegistro();
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

