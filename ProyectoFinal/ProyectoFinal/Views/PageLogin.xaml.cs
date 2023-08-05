using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ProyectoFinal.Views
{	
	public partial class PageLogin : ContentPage
	{	
		public PageLogin ()
		{
			InitializeComponent ();
		}

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            FirebaseUtilUsers util = new FirebaseUtilUsers();

            lblLogin.Text = await util.login(txtUsuario.Text, txtPassword.Text);
        }

        private void TapBackArrow_Tapped(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

    }
}

