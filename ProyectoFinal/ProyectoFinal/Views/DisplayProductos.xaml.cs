﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProyectoFinal.Views
{	
	public partial class DisplayProductos : ContentPage
	{	
		public DisplayProductos ()
		{
			InitializeComponent ();
            this.BindingContext = this;
        }

        public List<Category> MyCollections { get => GetCollections(); }

        private List<Category> GetCollections()
        {
            var colList = new List<Category>();
            colList.Add(new Category { Image = "electricas.png", Title = "Herramientas electricas" });
            colList.Add(new Category { Image = "equipamiento.png", Title = "Equipamiento" });
            colList.Add(new Category { Image = "accesorios.png", Title = "Accesorios" });
            colList.Add(new Category { Image = "manuales.png", Title = "Herramientas manuales" });
            return colList;
        }
    }

    public class Category
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
    }
}


