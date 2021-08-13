using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database.Query;
using PortalModelo.Models;
using PortalModelo.Services;
    
namespace PortalModelo.ViewModels
{
    public class VMPortales
    {
        List<MPortales> Portales = new List<MPortales>();

        public async Task <List <MPortales>> mostrar_portales ()
        {
            var datos = await ConexionFireBase.firebase
                .Child("Portales")
                .OrderByKey()
                .OnceAsync<MPortales>();

            foreach (var registrosdatos in datos)
            {
                MPortales parametros = new MPortales();
                parametros.PortalId = registrosdatos.Key;
                parametros.Municipio = registrosdatos.Object.Municipio;
                parametros.Status = registrosdatos.Object.Status;
                parametros.Fecha = registrosdatos.Object.Fecha;
                parametros.Foto = registrosdatos.Object.Foto;
                Portales.Add(parametros);
            }
            return Portales;
        }

        public async Task insertar_portal(MPortales parametros)
        {
            await ConexionFireBase.firebase
                .Child("Portales")
                .PostAsync(new MPortales()
                {
                    Municipio = parametros.Municipio,
                    Status = parametros.Status,
                    Fecha = parametros.Fecha,
                    Foto = parametros.Foto
                });
        }
    }
}
