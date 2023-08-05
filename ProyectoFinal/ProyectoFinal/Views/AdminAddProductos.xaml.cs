using System;
using System.Collections.Generic;

using Xamarin.Forms;
using ProyectoFinal.Model;
using ProyectoFinal.Utils;

namespace ProyectoFinal.Views
{	
	public partial class AdminAddProductos : ContentPage
	{	
		public AdminAddProductos ()
		{
			InitializeComponent ();
		}

        private async void BtnAgregarProducto_Clicked(object sender, EventArgs e)
        {

            var dt = DateTime.Now;

            string id = txtNombre.Text + txtMarca.Text + dt.ToString("ddMMyyyy");

            var producto = new Producto()
            {
                id_producto = id,
                nombre = txtNombre.Text,
                marca = txtMarca.Text,
                descripcion = txtDescripcion.Text,
                categoria = txtCategoria.Text,
                url_imagen = txtImagenURL.Text,
                precio = int.Parse(txtPrecio.Text)
            };

            FirebaseUtilProducts util = new FirebaseUtilProducts();

            util.setProducto("productos", id, producto);

        }

        private void TapBackArrow_Tapped(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}

