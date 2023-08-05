using System;
using FireSharp.Response;
using ProyectoFinal.Model;
using System.Collections.Generic;
using System.Diagnostics;
using FireSharp.Interfaces;
using System.Threading.Tasks;

namespace ProyectoFinal
{
	public class FirebaseUtilUsers : FirebaseUtil
	{

        public FirebaseUtilUsers() : base()
		{
		}

        public async void setUser(string collection, string id, Usuario usuario)
        {
            SetResponse response = await base.client.SetAsync(collection + "/" + id, usuario);
        }

        public async Task<string> login(string user, string pwd)
        {
            FirebaseResponse response = await base.client.GetAsync("usuarios");
            Dictionary<string, Usuario> data = response.ResultAs<Dictionary<string, Usuario>>();


            foreach (KeyValuePair<string, Usuario> entry in data)
            {
                Debug.WriteLine(entry.Value.usuario, entry.Value.password);

                if((String.Equals(user, entry.Value.usuario)) && (String.Equals(pwd, entry.Value.password)))
                {
                   return "Logueo exitoso.";
             
                }
                
            }

            return "Compruebe sus datos.";

        }
    }
}

