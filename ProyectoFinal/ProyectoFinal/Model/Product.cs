using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Model
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public bool HasOffer { get; set; }
        public decimal OfferPrice { get; set; }
    }
}

