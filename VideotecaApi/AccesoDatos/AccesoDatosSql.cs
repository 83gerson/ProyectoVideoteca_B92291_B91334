using Entidad.Entidades;

namespace AccesoDatos
{
    public class AccesoDatosSql : IAccesoDatosSql
    {
        private string smsError;

        #region ActorsCRUD
        /// <summary>
        /// Método api para agregar actores mediante una identidad aportada por el frontend
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public bool AgregarActors(Actors P_Entidad)
        {
            using (var contexto = new videotecalenguajesContext())
            {
                contexto.Actors.Add(P_Entidad);
                contexto.SaveChanges();
                return true;
            }
        }

        public List<Actors> ConsultarActors(Actors P_Entidad)
        {
            List<Actors> lst = new List<Actors>();
            if (P_Entidad != null && P_Entidad.Id > 0)
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    var coleccion = (from reg in contexto.Actors
                                     where reg.Id.Equals(P_Entidad.Id)
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            Actors r = new Actors
                            {
                                Id = item.Id,
                                ActorFirstName = item.ActorFirstName,
                                ActorLastName = item.ActorLastName
                            };
                            lst.Add(r);
                        }
                    }
                }
            }
            else
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    var coleccion = (from reg in contexto.Actors
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            Actors r = new Actors
                            {
                                Id = item.Id,
                                ActorFirstName = item.ActorFirstName,
                                ActorLastName = item.ActorLastName
                            };
                            lst.Add(r);
                        }
                    }
                }
            }
            return lst;
        }


        public bool ModificarActors(Actors P_Entidad)
        {
            try
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    var consulta = (from reg in contexto.Actors
                                    where reg.Id.Equals(P_Entidad.Id)
                                    select reg).FirstOrDefault();
                    if (consulta != null)
                    {
                        consulta.Id = P_Entidad.Id;
                        consulta.ActorFirstName = P_Entidad.ActorFirstName;
                        consulta.ActorLastName = P_Entidad.ActorLastName;
                        contexto.SaveChanges();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {
                smsError = ex.Message.ToString();
                return false;
            }
        }

        public bool EliminarActors(Actors P_Entidad)
        {
            try
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    contexto.Actors.Remove(P_Entidad);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                smsError = ex.Message.ToString();
                return false;
            }
        }

        #endregion

        #region CommentsCRUD

        public bool AgregarComments(Comments P_Entidad)
        {
            using (var contexto = new videotecalenguajesContext())
            {
                contexto.Comments.Add(P_Entidad);
                contexto.SaveChanges();
                return true;
            }
        }

        public List<Comments> ConsultarComments(Comments P_Entidad)
        {
            List<Comments> lst = new List<Comments>();
            if (P_Entidad != null && P_Entidad.CommentId > 0)
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    var coleccion = (from reg in contexto.Comments
                                     where reg.CommentId.Equals(P_Entidad.CommentId)
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            Comments r = new Comments
                            {
                                CommentId = item.CommentId,
                                MovieSeriesId = item.MovieSeriesId,
                                Comment = item.Comment,
                                UserName = item.UserName,
                            };
                            lst.Add(r);
                        }
                    }
                }
            }
            else
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    var coleccion = (from reg in contexto.Comments
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            Comments r = new Comments
                            {
                                CommentId = item.CommentId,
                                Comment = item.Comment,
                                MovieSeriesId = item.MovieSeriesId,
                                UserName = item.UserName

                            };
                            lst.Add(r);
                        }
                    }
                }
            }
            return lst;
        }

        public bool ModificarComments(Comments P_Entidad)
        {
            try
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    var consulta = (from reg in contexto.Comments
                                    where reg.CommentId.Equals(P_Entidad.CommentId)
                                    select reg).FirstOrDefault();
                    if (consulta != null)
                    {
                        consulta.Comment = P_Entidad.Comment;
                        contexto.SaveChanges();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {
                smsError = ex.Message.ToString();
                return false;
            }
        }

        public bool EliminarComments(Comments P_Entidad)
        {
            try
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    contexto.Comments.Remove(P_Entidad);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                smsError = ex.Message.ToString();
                return false;
            }
        }

        #endregion

        #region EpisodesCRUD

        public bool AgregarEpisode(Episodes P_Entidad)
        {
            using (var contexto = new videotecalenguajesContext())
            {
                contexto.Episodes.Add(P_Entidad);
                contexto.SaveChanges();
                return true;
            }
        }
        public List<Episodes> ConsultarEpisodes(Episodes P_Entidad)
        {
            List<Episodes> lst = new List<Episodes>();
            if (P_Entidad != null && P_Entidad.EpisodeId > 0)
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    var coleccion = (from reg in contexto.Episodes
                                     where reg.EpisodeId.Equals(P_Entidad.EpisodeId)
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            Episodes r = new Episodes
                            {
                                Tittle = item.Tittle,
                                Duration = item.Duration,
                                EpisodeNumber = item.EpisodeNumber

                            };
                            lst.Add(r);
                        }
                    }
                }
            }
            else
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    var coleccion = (from reg in contexto.Episodes
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            Episodes r = new Episodes
                            {
                                Tittle = item.Tittle,
                                Duration = item.Duration,
                                EpisodeNumber = item.EpisodeNumber
                            };
                            lst.Add(r);
                        }
                    }
                }
            }
            return lst;
        }

        public bool ModificarEpisodes(Episodes P_Entidad)
        {
            try
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    var consulta = (from reg in contexto.Episodes
                                    where reg.EpisodeId.Equals(P_Entidad.EpisodeId)
                                    select reg).FirstOrDefault();
                    if (consulta != null)
                    {
                        consulta.Tittle = P_Entidad.Tittle;
                        consulta.Duration = P_Entidad.Duration;
                        consulta.EpisodeNumber = P_Entidad.EpisodeNumber;
                        contexto.SaveChanges();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {
                smsError = ex.Message.ToString();
                return false;
            }
        }

        public bool EliminarEpisodes(Episodes P_Entidad)
        {
            try
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    contexto.Episodes.Remove(P_Entidad);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                smsError = ex.Message.ToString();
                return false;
            }
        }
        #endregion

        #region MoviesAndSeriesCRUD

        public bool AgregarMovies(MoviesAndSeries P_Entidad)
        {
            using (var contexto = new videotecalenguajesContext())
            {
                contexto.MoviesAndSeries.Add(P_Entidad);
                contexto.SaveChanges();
                return true;
            }
        }
        public List<MoviesAndSeries> ConsultarMovies(MoviesAndSeries P_Entidad)
        {
            List<MoviesAndSeries> lst = new List<MoviesAndSeries>();
            if (P_Entidad != null && P_Entidad.Id > 0)
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    var coleccion = (from reg in contexto.MoviesAndSeries
                                     where reg.Id.Equals(P_Entidad.Id)
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            MoviesAndSeries r = new MoviesAndSeries
                            {
                                Id=item.Id,
                                Director = item.Director,
                                Genre = item.Genre,
                                Duration = item.Duration,
                                NumSeasons = item.NumSeasons,
                                NumEpisodes = item.NumEpisodes,
                                Synopsis = item.Synopsis,
                                Title = item.Title,
                                Ratings = item.Ratings
                            };
                            lst.Add(r);
                        }
                    }
                }
            }
            else
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    var coleccion = (from reg in contexto.MoviesAndSeries
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            MoviesAndSeries r = new MoviesAndSeries
                            {
                                Id= item.Id,
                                Director = item.Director,
                                Genre = item.Genre,
                                Duration = item.Duration,
                                NumSeasons = item.NumSeasons,
                                NumEpisodes = item.NumEpisodes,
                                Synopsis = item.Synopsis,
                                Title = item.Title,
                                Ratings = item.Ratings,
                                ReleaseYear = item.ReleaseYear,
                                EpisodeDuration = item.EpisodeDuration
                            };
                            lst.Add(r);
                        }
                    }
                }
            }
            return lst;
        }

        public bool ModificarMovies(MoviesAndSeries P_Entidad)
        {
            try
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    var consulta = (from reg in contexto.MoviesAndSeries
                                    where reg.Id.Equals(P_Entidad.Id)
                                    select reg).FirstOrDefault();
                    if (consulta != null)
                    {
                        consulta.Id= P_Entidad.Id;
                        consulta.Title = P_Entidad.Title;
                        consulta.ReleaseYear = P_Entidad.ReleaseYear;
                        consulta.Synopsis = P_Entidad.Synopsis;
                        consulta.Ratings = P_Entidad.Ratings;
                        consulta.Duration = P_Entidad.Duration;
                        consulta.Genre = P_Entidad.Genre;
                        consulta.Episodes = P_Entidad.Episodes;

                        contexto.SaveChanges();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {
                smsError = ex.Message.ToString();
                return false;
            }
        }
        public bool EliminarMovies(MoviesAndSeries P_Entidad)
        {
            try
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    contexto.MoviesAndSeries.Remove(P_Entidad);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                smsError = ex.Message.ToString();
                return false;
            }
        }

        #endregion

        #region MoviesAndSeriesActorsCRUD
        public bool AgregarMoviesAndSeriesActors(MoviesAndSeriesActors P_Entidad)
        {
            using (var contexto = new videotecalenguajesContext())
            {
                contexto.MoviesAndSeriesActors.Add(P_Entidad);
                contexto.SaveChanges();
                return true;
            }
        }

        public List<MoviesAndSeriesActors> ConsultarMoviesAndSeriesActors(MoviesAndSeriesActors P_Entidad)
        {
            List<MoviesAndSeriesActors> lstunidades = new List<MoviesAndSeriesActors>();
            if (P_Entidad != null && P_Entidad.Id > 0)
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    var coleccion = (from reg in contexto.MoviesAndSeriesActors
                                     where reg.Id.Equals(P_Entidad.Id)
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            MoviesAndSeriesActors r = new MoviesAndSeriesActors
                            {
                                Id = item.Id,
                                Actor = item.Actor,
                                MoviesSeries = item.MoviesSeries,
                            };
                            lstunidades.Add(r);
                        }
                    }
                }
            }
            else
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    var coleccion = (from reg in contexto.MoviesAndSeriesActors
                                     where reg.Id.Equals(P_Entidad.Id)
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            MoviesAndSeriesActors r = new MoviesAndSeriesActors
                            {
                                Id = item.Id,
                                Actor = item.Actor,
                                MoviesSeries = item.MoviesSeries,
                            };
                            lstunidades.Add(r);
                        }
                    }
                }
            }
            return lstunidades;
        }



        public bool ModificarMoviesAndActor(MoviesAndSeriesActors P_Entidad)
        {
            try
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    var consulta = (from reg in contexto.MoviesAndSeriesActors
                                    where reg.Id.Equals(P_Entidad.Id)
                                    select reg).FirstOrDefault();
                    if (consulta != null)
                    {
                        consulta.Actor = P_Entidad.Actor;
                        consulta.MoviesSeries = P_Entidad.MoviesSeries;
                        contexto.SaveChanges();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {
                smsError = ex.Message.ToString();
                return false;
            }
        }

        public bool EliminarMoviesAndActors(MoviesAndSeriesActors P_Entidad)
        {
            try
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    contexto.MoviesAndSeriesActors.Remove(P_Entidad);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                smsError = ex.Message.ToString();
                return false;
            }
        }



        #endregion

        #region RatingCRUD
        public bool AgregarRatings(Ratings P_Entidad)
        {
            using (var contexto = new videotecalenguajesContext())
            {
                contexto.Ratings.Add(P_Entidad);
                contexto.SaveChanges();
                return true;
            }
        }
        public List<Ratings> ConsultarRatings(Ratings P_Entidad)
        {
            List<Ratings> lst = new List<Ratings>();
            if (P_Entidad != null && P_Entidad.RatingId > 0)
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    var coleccion = (from reg in contexto.Ratings
                                     where reg.RatingId.Equals(P_Entidad.RatingId)
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            Ratings r = new Ratings
                            {
                                RatingId = item.RatingId,
                                Username = item.Username,
                                MovieSeries = item.MovieSeries
                            };
                            lst.Add(r);
                        }
                    }
                }
            }
            else
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    var coleccion = (from reg in contexto.Ratings
                                     where reg.RatingId.Equals(P_Entidad.RatingId)
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            Ratings r = new Ratings
                            {
                                RatingId = item.RatingId,
                                Username = item.Username,
                                MovieSeries = item.MovieSeries
                            };
                            lst.Add(r);
                        }
                    }
                }
            }
            return lst;
        }

        public bool ModificarRatings(Ratings P_Entidad)
        {
            try
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    var consulta = (from reg in contexto.Ratings
                                    where reg.RatingId.Equals(P_Entidad.RatingId)
                                    select reg).FirstOrDefault();
                    if (consulta != null)
                    {
                        consulta.Rating = P_Entidad.Rating;
                        contexto.SaveChanges();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {
                smsError = ex.Message.ToString();
                return false;
            }
        }

        public bool EliminarRatings(Ratings P_Entidad)
        {
            try
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    contexto.Ratings.Remove(P_Entidad);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                smsError = ex.Message.ToString();
                return false;
            }
        }
        #endregion

        #region USERSCRUD

        public bool AgregarUsers(Users P_Entidad)
        {
            using (var contexto = new videotecalenguajesContext())
            {
                contexto.Users.Add(P_Entidad);
                contexto.SaveChanges();
                return true;
            }
        }
        public List<Users> ConsultarUsers(Users P_Entidad)
        {
            List<Users> lstunidades = new List<Users>();
            if (P_Entidad != null && P_Entidad.Username.Length > 0)
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    var coleccion = (from reg in contexto.Users
                                     where reg.Username.Equals(P_Entidad.Username)
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            Users r = new Users
                            {
                                Username = item.Username,
                                ImageUrl = item.ImageUrl,
                                Role = item.Role
                            };
                            lstunidades.Add(r);
                        }
                    }
                }
            }
            else
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    var coleccion = (from reg in contexto.Users
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            Users r = new Users
                            {
                                Username = item.Username,
                                ImageUrl = item.ImageUrl,
                                Role = item.Role
                            };
                            lstunidades.Add(r);
                        }
                    }
                }
            }
            return lstunidades;
        }

        public bool ModificarUsers(Users P_Entidad)
        {
            try
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    var consulta = (from reg in contexto.Users
                                    where reg.Username.Equals(P_Entidad.Username)
                                    select reg).FirstOrDefault();
                    if (consulta != null)
                    {
                        consulta.Username = P_Entidad.Username;
                        consulta.ImageUrl = P_Entidad.ImageUrl;
                        contexto.SaveChanges();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {
                smsError = ex.Message.ToString();
                return false;
            }
        }

        public bool EliminarUsers(Users P_Entidad)
        {
            try
            {
                using (var contexto = new videotecalenguajesContext())
                {
                    contexto.Users.Remove(P_Entidad);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                smsError = ex.Message.ToString();
                return false;
            }
        }

        #endregion

    }
}