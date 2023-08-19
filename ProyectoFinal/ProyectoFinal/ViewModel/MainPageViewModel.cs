using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProyectoFinal.ViewModel
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public bool HasOffer { get; set; }
        public decimal OfferPrice { get; set; }
    }
    public class MainPageViewModel
    {
    
            public ObservableCollection<Product> Products { get; set; }
            public MainPageViewModel()
            {
                Products = new ObservableCollection<Product>
            {
              
                 new Product
                {
                    Name = "Product 1",
                    Price = 10.99m,
                    Image = "destrozadora.png"
                },
                new Product
                {
                    Name = "Desbrozadora M18 FUEL Brushless String Trimmer",
                    Price = 19.99m,
                    Image = "desbrozadora.png"
                  },
                    new Product
                {
                    Name = "Destornillador de Impacto Milwaukee M12 FUEL 1/4\" Hex Impact Drive",
                    Price = 19.99m,
                    Image = "desbrozadora.png"
                  },
                        new Product
                {
                    Name = "Destructora de Ramas  M18 FUEL Wood Chipper/Shredder",
                    Price = 19.99m,
                    Image = "desbrozadora.png"
                 },
                            new Product
                {
                    Name = "Sopladora Inalámbrica M18 FUEL Blower",
                    Price = 19.99m,
                    Image = "desbrozadora.png"
                }
                };
    }
}
}
