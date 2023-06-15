using Microsoft.EntityFrameworkCore;
using ProyectoVideoteca_B92291_B91334.Models;

namespace ProyectoVideoteca_B92291_B91334.Data
{
    public class UCRTextContext : DbContext
    {
        public DbSet<Actors> Actors { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Episodes> Episodes { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<MoviesAndSeries> MoviesAndSeries { get; set; }
        public DbSet<MoviesAndSeriesActors> MoviesAndSeriesActors { get; set; }
        public DbSet<MoviesAndSeriesGenres> MoviesAndSeriesGenres { get; set; }
        public DbSet<Ratings> Ratings { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-HQR4548J;Database=videotecalenguajes;TrustServerCertificate=True;User Id=sa;Password=dylan2604;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MoviesAndSeriesGenres>()
                           .HasKey(msg => new { msg.movie_series_id, msg.genre_id });


            modelBuilder.Entity<MoviesAndSeriesGenres>()
                .HasOne(msg => msg.Genre)
                .WithMany(g => g.MovieAndSeriesGenres)
                .HasForeignKey(msg => msg.genre_id);

            modelBuilder.Entity<MoviesAndSeriesActors>()
                .HasKey(msa => new { msa.movies_series_id, msa.actor_id });


            modelBuilder.Entity<Comments>()
                .HasKey(c => c.comment_id);
                
            modelBuilder.Entity<Ratings>()
                .HasKey(r => r.rating_id);

            modelBuilder.Entity<Episodes>()
                .HasKey(e => e.episode_id);

            modelBuilder.Entity<Genres>()
                .HasKey(g => g.Id);

            modelBuilder.Entity<Actors>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<MoviesAndSeries>()
                .HasKey(ms => ms.id);
                

            modelBuilder.Entity<User>()
                .HasKey(u => u.Username);

            base.OnModelCreating(modelBuilder);
        }

    }
}
