using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using ProyectoFinal.Model;

namespace ProyectoFinal
{
	public class FirebaseUtil
	{
        IFirebaseClient client;

        public FirebaseUtil()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "bNFYTwInLY0IXT7Dbir0Qozf7nbGMQWBPpx3nelG",
                BasePath = "https://proyectofinal-22fbe-default-rtdb.firebaseio.com/"

            };

            client = new FireSharp.FirebaseClient(config);
        }

        public async void insertarUsuario(string collection, string id, Usuario usuario)
        {
            SetResponse response = await client.SetAsync(collection + "/" + id, usuario);
        }

        //public async void insertarProducto(string collection, string id, Producto producto)
        //{
        //    SetResponse response = await client.SetAsync(collection + "/" + id, producto);
        //}

        public async void get()
        {
            FirebaseResponse response = await client.GetAsync("usuarios");
            Dictionary<string, Usuario> data = response.ResultAs<Dictionary<string, Usuario>>();

            var asString = string.Join(Environment.NewLine, data);
            Debug.WriteLine(asString);
        }
    }
}

