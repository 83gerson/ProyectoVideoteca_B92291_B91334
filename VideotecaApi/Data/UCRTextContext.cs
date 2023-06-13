using Microsoft.EntityFrameworkCore;
using ProyectoVideoteca_B92291_B91334.Models;

namespace ProyectoVideoteca_B92291_B91334.Data
{
    public class UCRTextContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Actors> Actors { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Episodes> Episodes { get; set; }
        public DbSet<MoviesAndSeries> MoviesAndSeries { get; set; }
        public DbSet<MoviesAndSeriesActors> MoviesAndSeriesActors { get; set; }
        public DbSet<MoviesAndSeriesGenres> MoviesAndSeriesGenres { get; set; }
        public DbSet<Ratings> Ratings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-HQR4548J;Database=B91334;TrustServerCertificate=True;User Id=sa;Password=dylan2604;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MoviesAndSeriesGenres>()
                .HasKey(msg => new { msg.movie_series_id, msg.genre_id });

            modelBuilder.Entity<MoviesAndSeriesGenres>()
                .HasOne(msg => msg.MovieAndSeries)
                .WithMany(ms => ms.Genres)
                .HasForeignKey(msg => msg.movie_series_id);

            modelBuilder.Entity<MoviesAndSeriesGenres>()
                .HasOne(msg => msg.Genre)
                .WithMany(g => g.MovieAndSeriesGenres)
                .HasForeignKey(msg => msg.genre_id);

            modelBuilder.Entity<MoviesAndSeriesActors>()
                .HasKey(msa => new { msa.movies_series_id, msa.actor_id });

            modelBuilder.Entity<MoviesAndSeriesActors>()
                .HasOne(msa => msa.MovieAndSeries)
                .WithMany(ms => ms.Actors)
                .HasForeignKey(msa => msa.movies_series_id);

            modelBuilder.Entity<MoviesAndSeriesActors>()
                .HasOne(msa => msa.Actor)
                .WithMany(a => a.MoviesAndSeriesActors)
                .HasForeignKey(msa => msa.actor_id);

            modelBuilder.Entity<Comments>()
                .HasOne(c => c.MovieAndSeries)
                .WithMany(ms => ms.Comments)
                .HasForeignKey(c => c.movie_series_id);

            modelBuilder.Entity<Comments>()
                .HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.user_id);

            modelBuilder.Entity<Ratings>()
                .HasOne(r => r.MovieAndSeries)
                .WithMany(ms => ms.Ratings)
                .HasForeignKey(r => r.movie_series_id);

            modelBuilder.Entity<Ratings>()
                .HasOne(r => r.User)
                .WithMany(u => u.Ratings)
                .HasForeignKey(r => r.user_id);

            // Configuración de otras relaciones según los modelos proporcionados
            modelBuilder.Entity<Episodes>()
                .HasOne(e => e.MovieAndSeries)
                .WithMany(ms => ms.Episodes)
                .HasForeignKey(e => e.movies_series_id);

            // Repite el proceso para configurar las demás relaciones

            base.OnModelCreating(modelBuilder);
        }

    }
}
