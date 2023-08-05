using System;
namespace ProyectoFinal.Model
{
	public class Producto
	{
        public string id_producto { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string descripcion { get; set; }
        public string categoria { get; set; }
        public string url_imagen { get; set; }
        public int precio { get; set; }
    }
}

