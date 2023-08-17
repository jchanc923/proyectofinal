using ProyectoFinal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Producto = ProyectoFinal.Model.Producto;

namespace ProyectoFinal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Shopping : ContentPage
    {

        public IList<Producto> Productos { get; private set; }
        public Shopping()
        {
            InitializeComponent();
            Productos = new List<Producto>();


           Productos.Add(new Producto
           {
               nombre = "Desbrozadora M18 FUEL™",
               precio = 19000,
               url_imagen = "https://firebasestorage.googleapis.com/v0/b/construcshoptools.appspot.com/o/assets%2Fassets%2Fdesbrozadora.png?alt=media&token=c5f7c5b6-388e-4d92-846e-fb4ed365545c",
               descripcion = "Taladro/destornillador M18 FUEL™ de ½” con ONE-KEY™"
           });

            Productos.Add(new Producto
            {
               nombre = "Destrozadora M18 FUEL™",
                precio = 1100,
                url_imagen = "https://firebasestorage.googleapis.com/v0/b/construcshoptools.appspot.com/o/assets%2Fassets%2Ftaladro3.png?alt=media&token=3e27b3f1-177a-49d0-a5c8-05fe951a8d7d",
                descripcion = "Taladro/destornillador M18 FUEL™ de ½” con ONE-KEY™"
            });

            Productos.Add(new Producto
            {
                nombre = "Taladro/destornillador de instalación M12 FUEL™",
                precio = 1000,
                url_imagen = "https://firebasestorage.googleapis.com/v0/b/construcshoptools.appspot.com/o/assets%2Fassets%2Ftaladro.png?alt=media&token=29f870ea-f92f-4bb0-8d52-43f0a5d72799",
                descripcion = "Taladro/destornillador M18 FUEL™ de ½” con ONE-KEY™"
            });

            Productos.Add(new Producto
            {
                nombre = "Kit de taladro magnético M18 FUEL™ de 1-1/2\"",
                precio = 1000,
                url_imagen = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3b/Escudo_de_la_Provincia_de_Lim%C3%B3n.svg/1540px-Escudo_de_la_Provincia_de_Lim%C3%B3n.svg.png",
                descripcion = "Taladro/destornillador M18 FUEL™ de ½” con ONE-KEY™"
            });

            Productos.Add(new Producto
            {
                nombre = "Taladro/destornillador M18 FUEL™ de ½” con ONE-KEY™",
                precio = 2200,
                url_imagen = @"https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/Escudo_de_la_Provincia_de_Heredia.svg/1560px-Escudo_de_la_Provincia_de_Heredia.svg.png",
                descripcion = "Taladro/destornillador M18 FUEL™ de ½” con ONE-KEY™"
            });

            Productos.Add(new Producto
            {
                nombre = "Kit de taladro magnético M18 FUEL™ de 1-1/2\"",
                precio = 34000,
                url_imagen = "https://i.pinimg.com/originals/c6/28/8d/c6288dc9fcadea44e8510a877c70ecaa.png",
                descripcion = "Taladro/destornillador M18 FUEL™ de ½” con ONE-KEY™"
            });
            Productos.Add(new Producto
            {
                nombre = "Taladro/destornillador M18 FUEL™ de ½” con ONE-KEY™",
                precio = 54000,
                url_imagen ="https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Escudo_de_la_Provincia_de_Puntarenas.svg/1669px-Escudo_de_la_Provincia_de_Puntarenas.svg.png",
                  descripcion = "Taladro/destornillador M18 FUEL™ de ½” con ONE-KEY™"
            });

            Productos.Add(new Producto
            {
                nombre = "Taladro/destornillador M18 FUEL™ de ½” con ONE-KEY™",
                precio = 2222,
                url_imagen = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/Escudo_de_la_Provincia_de_Heredia.svg/1560px-Escudo_de_la_Provincia_de_Heredia.svg.png",
                  descripcion = "Taladro/destornillador M18 FUEL™ de ½” con ONE-KEY™"
            });

            Productos.Add(new Producto
            {
                nombre = "Kit de taladro magnético M18 FUEL™ de 1-1/2\"",
                precio = 34000,
                url_imagen = "https://i.pinimg.com/originals/c6/28/8d/c6288dc9fcadea44e8510a877c70ecaa.png",
                descripcion = "Taladro/destornillador M18 FUEL™ de ½” con ONE-KEY™"
            });
            Productos.Add(new Producto
            {
                nombre = "Taladro/destornillador M18 FUEL™ de ½” con ONE-KEY™",
                precio = 5000,
                url_imagen = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Escudo_de_la_Provincia_de_Puntarenas.svg/1669px-Escudo_de_la_Provincia_de_Puntarenas.svg.png",
                  descripcion = "Taladro/destornillador M18 FUEL™ de ½” con ONE-KEY™"
            });
            BindingContext = this;





        }
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Producto selectedItem = e.SelectedItem as Producto;
        avisoDir(Texto: selectedItem.nombre + " Descripcion: " + selectedItem.descripcion);
    }


    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        Producto tappedItem = e.Item as Producto;
    }


    public async Task avisoDir(string Texto)
    {
        await DisplayAlert("Seleccionada", Texto, "Aceptar");
    }
}
}
