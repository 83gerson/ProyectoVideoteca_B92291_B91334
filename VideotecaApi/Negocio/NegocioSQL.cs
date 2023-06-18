using Entidad.Entidades;
using AccesoDatos;

namespace Negocio

{
    public class NegocioSQL : INegocioSQL
    {
        private readonly IAccesoDatosSql _accesoDatosSQL;
        public NegocioSQL(IAccesoDatosSql accesoDatosSQL)
        {
            _accesoDatosSQL = accesoDatosSQL;
        }

        #region Actors
        public bool AgregarActors(Actors P_Entidad)
        {
            return _accesoDatosSQL.AgregarActors(P_Entidad);
        }
        public List<Actors> ConsultarActors(Actors P_Entidad)
        {
            return _accesoDatosSQL.ConsultarActors(P_Entidad);
        }
        public bool ModificarActors(Actors P_Entidad)
        {
            return _accesoDatosSQL.ModificarActors(P_Entidad);
        }
        public bool EliminarActors(Actors P_Entidad)
        {
            return _accesoDatosSQL.EliminarActors(P_Entidad);
        }
        #endregion

        #region Comments
        public bool AgregarComments(Comments P_Entidad)
        {
            return _accesoDatosSQL.AgregarComments(P_Entidad);
        }
        public List<Comments> ConsultarComments(Comments P_Entidad)
        {
            return _accesoDatosSQL.ConsultarComments(P_Entidad);
        }
        public bool ModificarComments(Comments P_Entidad)
        {
            return _accesoDatosSQL.ModificarComments(P_Entidad);
        }
        public bool EliminarComments(Comments P_Entidad)
        {
            return _accesoDatosSQL.EliminarComments(P_Entidad);
        }
        #endregion

        #region Episode
        public bool AgregarEpisode(Episodes P_Entidad)
        {
            return _accesoDatosSQL.AgregarEpisode(P_Entidad);
        }
        public List<Episodes> ConsultarEpisodes(Episodes P_Entidad)
        {
            return _accesoDatosSQL.ConsultarEpisodes(P_Entidad);
        }
        public bool ModificarEpisodes(Episodes P_Entidad)
        {
            return _accesoDatosSQL.ModificarEpisodes(P_Entidad);
        }
        public bool EliminarEpisodes(Episodes P_Entidad)
        {
            return _accesoDatosSQL.EliminarEpisodes(P_Entidad);
        }
        #endregion

        #region MoviesAndSeries

        public bool AgregarMovies(MoviesAndSeries P_Entidad)
        {
            return _accesoDatosSQL.AgregarMovies(P_Entidad);
        }
        public List<MoviesAndSeries> ConsultarMovies(MoviesAndSeries P_Entidad)
        {
            return _accesoDatosSQL.ConsultarMovies(P_Entidad);
        }
        public bool ModificarMovies(MoviesAndSeries P_Entidad)
        {
            return _accesoDatosSQL.ModificarMovies(P_Entidad);
        }
        public bool EliminarMovies(MoviesAndSeries P_Entidad)
        {
            return _accesoDatosSQL.EliminarMovies(P_Entidad);
        }

        #endregion

        #region MoviesAndSeriesActors
        public bool AgregarMoviesAndSeriesActors(MoviesAndSeriesActors P_Entidad)
        {
            return _accesoDatosSQL.AgregarMoviesAndSeriesActors(P_Entidad);
        }
        public List<MoviesAndSeriesActors> ConsultarMoviesAndSeriesActors(MoviesAndSeriesActors P_Entidad)
        {
            return _accesoDatosSQL.ConsultarMoviesAndSeriesActors(P_Entidad);
        }
        public bool ModificarMoviesAndActor(MoviesAndSeriesActors P_Entidad)
        {
            return _accesoDatosSQL.ModificarMoviesAndActor(P_Entidad);
        }
        public bool EliminarMoviesAndActors(MoviesAndSeriesActors P_Entidad)
        {
            return _accesoDatosSQL.EliminarMoviesAndActors(P_Entidad);
        }
        #endregion

        #region Ratings
        public bool AgregarRatings(Ratings P_Entidad)
        {
            return _accesoDatosSQL.AgregarRatings(P_Entidad);
        }
        public List<Ratings> ConsultarRatings(Ratings P_Entidad)
        {
            return _accesoDatosSQL.ConsultarRatings(P_Entidad);
        }
        public bool ModificarRatings(Ratings P_Entidad)
        {
            return _accesoDatosSQL.ModificarRatings(P_Entidad);
        }
        public bool EliminarRatings(Ratings P_Entidad)
        {
            return _accesoDatosSQL.EliminarRatings(P_Entidad);
        }

        #endregion

        #region Users
        public bool AgregarUsers(Users P_Entidad)
        {
            return _accesoDatosSQL.AgregarUsers(P_Entidad);
        }
        public List<Users> ConsultarUsers(Users P_Entidad)
        {
            return _accesoDatosSQL.ConsultarUsers(P_Entidad);
        }
        public bool ModificarUsers(Users P_Entidad)
        {
            return _accesoDatosSQL.ModificarUsers(P_Entidad);
        }
        public bool EliminarUsers(Users P_Entidad)
        {
            return _accesoDatosSQL.EliminarUsers(P_Entidad);
        }
        #endregion




    }


}