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
        public IFirebaseClient client;

        public FirebaseUtil()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "bNFYTwInLY0IXT7Dbir0Qozf7nbGMQWBPpx3nelG",
                BasePath = "https://proyectofinal-22fbe-default-rtdb.firebaseio.com/"

            };

            client = new FireSharp.FirebaseClient(config);
        }

    }
}

