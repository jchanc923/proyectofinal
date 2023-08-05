using System;
using FireSharp.Response;
using ProyectoFinal.Model;

namespace ProyectoFinal.Utils
{
	public class FirebaseUtilProducts : FirebaseUtil
    {
		public FirebaseUtilProducts() : base()
        {
		}


        public async void setProducto(string collection, string id, Producto producto)
        {
            SetResponse response = await base.client.SetAsync(collection + "/" + id, producto);
        }

    }
}

