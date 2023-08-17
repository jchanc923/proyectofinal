using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Model
{
   public class Product
 
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }


}