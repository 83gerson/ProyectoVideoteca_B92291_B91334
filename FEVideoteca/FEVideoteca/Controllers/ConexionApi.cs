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

            string rutaApi = "api/Comments/ConsultarComments";
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

        #region Episodes

        public async Task<bool> AgregarEpisodes(Episodes P_entidad)
        {

            string rutaApi = "api/Episodes/AgregarEpisodes";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_entidad);

            return resultadoConsumo.IsSuccessStatusCode;
        }

        public async Task<List<Episodes>> ConsultarEpisodes(Episodes P_Entidad)
        {
            List<Episodes> lstComments = new List<Episodes>();

            string rutaApi = "api/Episodes/ConsultarEpisodes";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_Entidad);
            if (resultadoConsumo.IsSuccessStatusCode)
            {
                string jsonString = await resultadoConsumo.Content.ReadAsStringAsync();
                lstComments = JsonConvert.DeserializeObject<List<Episodes>>(jsonString);

            }
            return lstComments;

        }


        public async Task<bool> ModificarEpisodes(Episodes P_Entidad)
        {

            string rutaApi = "api/Episodes/ModificarEpisodes";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_Entidad);

            return resultadoConsumo.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarEpisodes(Episodes P_entidad)
        {

            string rutaApi = "api/Episodes/EliminarEpisodes";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_entidad);

            return resultadoConsumo.IsSuccessStatusCode;
        }

        #endregion

        #region MoviesAndSeries

        public async Task<bool> AgregarMovies(MoviesAndSeries P_entidad)
        {

            string rutaApi = "api/MoviesAndSeries/AgregarMovies";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_entidad);

            return resultadoConsumo.IsSuccessStatusCode;
        }

        public async Task<List<MoviesAndSeries>> ConsultarMovies(MoviesAndSeries P_Entidad)
        {
            List<MoviesAndSeries> lstComments = new List<MoviesAndSeries>();

            string rutaApi = "api/MoviesAndSeries/ConsultarMovies";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_Entidad);
            if (resultadoConsumo.IsSuccessStatusCode)
            {
                string jsonString = await resultadoConsumo.Content.ReadAsStringAsync();
                lstComments = JsonConvert.DeserializeObject<List<MoviesAndSeries>>(jsonString);

            }
            return lstComments;

        }


        public async Task<bool> ModificarMovies(MoviesAndSeries P_Entidad)
        {

            string rutaApi = "api/MoviesAndSeries/ModificarMovies";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_Entidad);

            return resultadoConsumo.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarMovies(MoviesAndSeries P_entidad)
        {

            string rutaApi = "api/MoviesAndSeries/EliminarMovies";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_entidad);

            return resultadoConsumo.IsSuccessStatusCode;
        }

        #endregion

        #region MoviesAndSeriesActors

        public async Task<bool> AgregarMoviesAndSeriesActors(MoviesAndSeriesActors P_entidad)
        {

            string rutaApi = "api/MoviesAndSeriesActors/AgregarMoviesAndSeriesActors";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_entidad);

            return resultadoConsumo.IsSuccessStatusCode;
        }

        public async Task<List<MoviesAndSeriesActors>> ConsultarMoviesAndSeriesActors(MoviesAndSeriesActors P_Entidad)
        {
            List<MoviesAndSeriesActors> lstComments = new List<MoviesAndSeriesActors>();

            string rutaApi = "api/MoviesAndSeriesActors/ConsultarMoviesAndSeriesActors";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_Entidad);
            if (resultadoConsumo.IsSuccessStatusCode)
            {
                string jsonString = await resultadoConsumo.Content.ReadAsStringAsync();
                lstComments = JsonConvert.DeserializeObject<List<MoviesAndSeriesActors>>(jsonString);

            }
            return lstComments;

        }


        public async Task<bool> ModificarMoviesAndActor(MoviesAndSeriesActors P_Entidad)
        {

            string rutaApi = "api/MoviesAndSeriesActors/ModificarMoviesAndActor";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_Entidad);

            return resultadoConsumo.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarMoviesAndActors(MoviesAndSeriesActors P_entidad)
        {

            string rutaApi = "api/MoviesAndSeriesActors/EliminarMoviesAndActors";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_entidad);

            return resultadoConsumo.IsSuccessStatusCode;
        }
        #endregion

        #region Ratings

        public async Task<bool> AgregarRatings(Ratings P_entidad)
        {

            string rutaApi = "api/Ratings/AgregarRatings";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_entidad);

            return resultadoConsumo.IsSuccessStatusCode;
        }

        public async Task<List<Ratings>> ConsultarRatings(Ratings P_Entidad)
        {
            List<Ratings> lstComments = new List<Ratings>();

            string rutaApi = "api/Ratings/ConsultarRatings";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_Entidad);
            if (resultadoConsumo.IsSuccessStatusCode)
            {
                string jsonString = await resultadoConsumo.Content.ReadAsStringAsync();
                lstComments = JsonConvert.DeserializeObject<List<Ratings>>(jsonString);

            }
            return lstComments;

        }


        public async Task<bool> ModificarRatings(Ratings P_Entidad)
        {

            string rutaApi = "api/Ratings/ModificarRatings";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_Entidad);

            return resultadoConsumo.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarRatings(Ratings P_entidad)
        {

            string rutaApi = "api/Ratings/EliminarRatings";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_entidad);

            return resultadoConsumo.IsSuccessStatusCode;
        }
        #endregion

        #region Users

        public async Task<bool> AgregarUsers(Users P_entidad)
        {

            string rutaApi = "api/Users/AgregarUsers";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_entidad);

            return resultadoConsumo.IsSuccessStatusCode;
        }

        public async Task<List<Users>> ConsultarRatings(Users P_Entidad)
        {
            List<Users> lstComments = new List<Users>();

            string rutaApi = "api/Users/ConsultarUsers";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_Entidad);
            if (resultadoConsumo.IsSuccessStatusCode)
            {
                string jsonString = await resultadoConsumo.Content.ReadAsStringAsync();
                lstComments = JsonConvert.DeserializeObject<List<Users>>(jsonString);

            }
            return lstComments;

        }


        public async Task<bool> ModificarUsers(Users P_Entidad)
        {

            string rutaApi = "api/Users/ModificarUsers";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_Entidad);

            return resultadoConsumo.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarUsers(Users P_entidad)
        {

            string rutaApi = "api/Users/EliminarUsers";
            HttpResponseMessage resultadoConsumo = await conexionCliente.PostAsJsonAsync(rutaApi, P_entidad);

            return resultadoConsumo.IsSuccessStatusCode;
        }
        #endregion

    }
}
