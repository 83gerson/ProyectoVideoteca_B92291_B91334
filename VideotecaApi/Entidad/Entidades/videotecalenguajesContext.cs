using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entidad.Entidades
{
    public partial class videotecalenguajesContext : DbContext
    {
        public videotecalenguajesContext()
        {
        }

        public videotecalenguajesContext(DbContextOptions<videotecalenguajesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actors> Actors { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Episodes> Episodes { get; set; }
        public virtual DbSet<MoviesAndSeries> MoviesAndSeries { get; set; }
        public virtual DbSet<MoviesAndSeriesActors> MoviesAndSeriesActors { get; set; }
        public virtual DbSet<Ratings> Ratings { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-N2FI4RE;Initial Catalog=videotecalenguajes;TrustServerCertificate=true;user id=sa; password=sa123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Actors>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActorFirstName)
                    .IsRequired()
                    .HasColumnName("actor_first_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ActorLastName)
                    .IsRequired()
                    .HasColumnName("actor_last_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PK__Comments__E7957687E5D684CA");

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.MovieSeriesId).HasColumnName("movie_series_id");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.MovieSeries)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.MovieSeriesId)
                    .HasConstraintName("FK__Comments__movie___35BCFE0A");

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.UserName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Comments__UserNa__36B12243");
            });

            modelBuilder.Entity<Episodes>(entity =>
            {
                entity.HasKey(e => e.EpisodeId)
                    .HasName("PK__Episodes__84780355CADB3016");

                entity.Property(e => e.EpisodeId)
                    .HasColumnName("episode_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Duration)
                    .IsRequired()
                    .HasColumnName("duration")
                    .HasMaxLength(255);

                entity.Property(e => e.EpisodeNumber).HasColumnName("episode_number");

                entity.Property(e => e.MoviesSeriesId).HasColumnName("movies_series_id");

                entity.Property(e => e.Tittle)
                    .IsRequired()
                    .HasColumnName("tittle")
                    .HasMaxLength(255);

                entity.HasOne(d => d.MoviesSeries)
                    .WithMany(p => p.Episodes)
                    .HasForeignKey(d => d.MoviesSeriesId)
                    .HasConstraintName("FK__Episodes__movies__32E0915F");
            });

            modelBuilder.Entity<MoviesAndSeries>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Director)
                    .IsRequired()
                    .HasColumnName("director")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Duration)
                    .IsRequired()
                    .HasColumnName("duration")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EpisodeDuration)
                    .IsRequired()
                    .HasColumnName("episode_duration")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Genre)
                    .IsRequired()
                    .HasColumnName("genre")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumEpisodes)
                    .IsRequired()
                    .HasColumnName("num_episodes")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumSeasons)
                    .IsRequired()
                    .HasColumnName("num_seasons")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReleaseYear).HasColumnName("release_year");

                entity.Property(e => e.Synopsis)
                    .IsRequired()
                    .HasColumnName("synopsis")
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MoviesAndSeriesActors>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActorId).HasColumnName("actor_id");

                entity.Property(e => e.MoviesSeriesId).HasColumnName("movies_series_id");

                entity.HasOne(d => d.Actor)
                    .WithMany(p => p.MoviesAndSeriesActors)
                    .HasForeignKey(d => d.ActorId)
                    .HasConstraintName("FK__MoviesAnd__actor__2F10007B");

                entity.HasOne(d => d.MoviesSeries)
                    .WithMany(p => p.MoviesAndSeriesActors)
                    .HasForeignKey(d => d.MoviesSeriesId)
                    .HasConstraintName("FK__MoviesAnd__movie__2E1BDC42");
            });

            modelBuilder.Entity<Ratings>(entity =>
            {
                entity.HasKey(e => e.RatingId)
                    .HasName("PK__Ratings__D35B278B1A220E67");

                entity.Property(e => e.RatingId)
                    .HasColumnName("rating_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.MovieSeriesId).HasColumnName("movie_series_id");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(255);

                entity.HasOne(d => d.MovieSeries)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.MovieSeriesId)
                    .HasConstraintName("FK__Ratings__movie_s__2A4B4B5E");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("FK__Ratings__usernam__2B3F6F97");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__Users__536C85E5B1198DCD");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(255);
            });
        }
    }
}
