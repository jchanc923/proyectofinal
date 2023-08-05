using System;
using System.Collections.Generic;

using Xamarin.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Diagnostics;
using System.Text.Json;
using ProyectoFinal.Model;

namespace ProyectoFinal.Views
{	
	public partial class PageRegistro : ContentPage
	{
        public PageRegistro()
        {
            InitializeComponent();
        }

        private async void BtnRegistrar_Clicked(object sender, EventArgs e)
        {

            var usuario = new Usuario()
            {
                usuario = txtUsuario.Text,
                correo = txtCorreo.Text,
                nombre = txtNombre.Text,
                password = txtPassword.Text,
                tipoDeUsuario = "normal",
                identificacion = txtIdentificacion.Text
            };

            FirebaseUtilUsers util = new FirebaseUtilUsers();

            util.set("usuarios", txtIdentificacion.Text, usuario);

        }

        private void TapBackArrow_Tapped(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void TapLabelTerminosCondiciones_Tapped(object sender, EventArgs e)
        {
            popupTerminosCondiciones.IsVisible = true;
        }

        private void BtnCerrarModal_Clicked(object sender, EventArgs e)
        {
            popupTerminosCondiciones.IsVisible = false;
        }
    }
}

