using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }
        private List<Product> GetCollections()
        {
            var trendList = new List<Product>();
            trendList.Add(new Product { Image = "desbrozadora.png", Name = "Desbrozadora M18 FUEL™", Price = "$431.50" });
            trendList.Add(new Product { Image = "destrozadora.png", Name = "Desbrozadora M18 FUEL™", Price = "$249.99" });
            trendList.Add(new Product { Image = "taladro.png", Name = "Taladro/destornillador de instalación M12 FUEL™", Price = "$140.99" });
            return trendList;
        }

        private List<Product> GetTrends()
        {
            var colList = new List<Product>();
            colList.Add(new Product { Image = "kittaladro.png", Name = "Kit de taladro magnético M18 FUEL™ de 1-1/2\"", Price = "$222.99" });
            colList.Add(new Product { Image = "taladro.png", Name = "Taladro/destornillador M18 FUEL™ de ½” con ONE-KEY™", Price = "$225.99" });
            colList.Add(new Product { Image = "kittaladro.png", Name = "Kit de taladro magnético M18 FUEL™ de 1-1/2\"", Price = "$222.99" });
            colList.Add(new Product { Image = "taladro.png", Name = "Taladro/destornillador M18 FUEL™ de ½” con ONE-KEY™", Price = "$225.99" });
            colList.Add(new Product { Image = "kittaladro.png", Name = "Kit de taladro magnético M18 FUEL™ de 1-1/2\"", Price = "$222.99" });
            colList.Add(new Product { Image = "taladro.png", Name = "Taladro/destornillador M18 FUEL™ de ½” con ONE-KEY™", Price = "$225.99" });
            return colList;
        }

        public class Product
        {
            public string Name { get; set; }
            public string Price { get; set; }
            public string Image { get; set; }
        }
    }
}


