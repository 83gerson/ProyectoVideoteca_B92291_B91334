using Entidad.Entidades;
using System.Collections.Generic;

namespace Negocio
{
    public interface INegocioSQL
    {
        #region Actors

        bool AgregarActors(Actors P_Entidad);

        List<Actors> ConsultarActors(Actors P_Entidad);

        bool ModificarActors(Actors P_Entidad);

        bool EliminarActors(Actors P_Entidad);

        #endregion

        #region Comments

        bool AgregarComments(Comments P_Entidad);

        List<Comments> ConsultarComments(Comments P_Entidad);

        bool ModificarComments(Comments P_Entidad);

        bool EliminarComments(Comments P_Entidad);

        #endregion

        #region Episodes

        bool AgregarEpisode(Episodes P_Entidad);

        List<Episodes> ConsultarEpisodes(Episodes P_Entidad);

        bool ModificarEpisodes(Episodes P_Entidad);

        bool EliminarEpisodes(Episodes P_Entidad);

        #endregion

        #region MoviesAndSeries

        bool AgregarMovies(MoviesAndSeries P_Entidad);

        List<MoviesAndSeries> ConsultarMovies(MoviesAndSeries P_Entidad);

        bool ModificarMovies(MoviesAndSeries P_Entidad);

        bool EliminarMovies(MoviesAndSeries P_Entidad);

        #endregion

        #region MoviesAndSeriesActors

        bool AgregarMoviesAndSeriesActors(MoviesAndSeriesActors P_Entidad);

        List<MoviesAndSeriesActors> ConsultarMoviesAndSeriesActors(MoviesAndSeriesActors P_Entidad);

        bool ModificarMoviesAndActor(MoviesAndSeriesActors P_Entidad);

        bool EliminarMoviesAndActors(MoviesAndSeriesActors P_Entidad);

        #endregion

        #region Ratings

        bool AgregarRatings(Ratings P_Entidad);

        List<Ratings> ConsultarRatings(Ratings P_Entidad);

        bool ModificarRatings(Ratings P_Entidad);

        bool EliminarRatings(Ratings P_Entidad);

        #endregion

        #region Users

        bool AgregarUsers(Users P_Entidad);

        List<Users> ConsultarUsers(Users P_Entidad);

        bool ModificarUsers(Users P_Entidad);

        bool EliminarUsers(Users P_Entidad);

        #endregion

    }
}
