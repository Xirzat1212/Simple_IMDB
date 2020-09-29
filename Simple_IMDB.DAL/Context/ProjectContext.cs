using Simple_IMDB.Map.Mapping;
using Simple_IMDB.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_IMDB.DAL.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=.;Database=Simple_IMDB_Db;Integrated Security=True;";
        }

        public DbSet<Film> Films { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<CategoryToFilm> CategoryToFilms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new FilmMap());
            modelBuilder.Configurations.Add(new LikeMap());
            modelBuilder.Configurations.Add(new CategoryToFilmMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
