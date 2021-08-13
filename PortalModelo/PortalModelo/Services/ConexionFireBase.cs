using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace PortalModelo.Services
{
    public class ConexionFireBase
    {
        public static FirebaseClient firebase = new FirebaseClient("https://portales-79969-default-rtdb.firebaseio.com/Portales");
    }
}
