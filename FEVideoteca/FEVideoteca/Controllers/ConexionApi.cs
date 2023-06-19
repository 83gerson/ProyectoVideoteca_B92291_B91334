using FEVideoteca.Models;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace FEVideoteca.Controllers
{
    public class ConexionApi
    {
        #region Propiedad De Conexión
        /// <summary>
        /// Variable conexion cliente servidor
        /// </summary>
        public HttpClient conexionCliente { get; set; }


        #endregion


        #region Constructor de conexión

        public ConexionApi() {
            conexionCliente = new HttpClient();

            parametrosBase();

        }




        #endregion


        #region Parametros de Conexion Api

        private void parametrosBase()
        { 

            conexionCliente.BaseAddress = new Uri("http://localhost:5180/");

            conexionCliente.DefaultRequestHeaders.Accept.Clear();

            conexionCliente.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }




        #endregion

        #region Actors

        public async Task<bool> AgregarActors(Actors P_entidad) {

            string rutaApi = "api/Actors/AgregarActors";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_entidad);

            return resultadoConsumo.IsSuccessStatusCode;
        
        
        }

        public async Task<List<Actors>> ConsultarActors(Actors P_Entidad)
        {
            List<Actors> lstActors = new List<Actors>();

            string rutaApi = "api/Actors/ConsultarActors";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_Entidad);
            if (resultadoConsumo.IsSuccessStatusCode)
            {
                string jsonString= await resultadoConsumo.Content.ReadAsStringAsync();
                lstActors= JsonConvert.DeserializeObject<List<Actors>>(jsonString);

            }
            return lstActors;

        }


        public async Task<bool> ModificarActors(Actors P_Entidad)
        {

            string rutaApi = "api/Actors/ModificarActors";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_Entidad);

            return resultadoConsumo.IsSuccessStatusCode;


        }

        public async Task<bool> EliminarActors(Actors P_entidad)
        {

            string rutaApi = "api/Actors/EliminarActors";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_entidad);

            return resultadoConsumo.IsSuccessStatusCode;


        }

        #endregion

        #region Comments

        public async Task<bool> AgregarComments(Comments P_entidad)
        {

            string rutaApi = "api/Comments/AgregarComments";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_entidad);

            return resultadoConsumo.IsSuccessStatusCode;


        }

        public async Task<List<Comments>> ConsultarComments(Comments P_Entidad)
        {
            List<Comments> lstComments = new List<Comments>();

            string rutaApi = "api/Actors/ConsultarActors";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_Entidad);
            if (resultadoConsumo.IsSuccessStatusCode)
            {
                string jsonString = await resultadoConsumo.Content.ReadAsStringAsync();
                lstComments = JsonConvert.DeserializeObject<List<Comments>>(jsonString);

            }
            return lstComments;

        }


        public async Task<bool> ModificarComments(Comments P_Entidad)
        {

            string rutaApi = "api/Comments/ModificarComments";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_Entidad);

            return resultadoConsumo.IsSuccessStatusCode;


        }

        public async Task<bool> EliminarComments(Comments P_entidad)
        {

            string rutaApi = "api/Comments/EliminarComments";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_entidad);

            return resultadoConsumo.IsSuccessStatusCode;


        }

        #endregion


    }
}
