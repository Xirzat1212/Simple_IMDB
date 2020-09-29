using Simple_IMDB.Core.Map;
using Simple_IMDB.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_IMDB.Map.Mapping
{
    public class FilmMap: CoreMap<Film>
    {
        public FilmMap()
        {
            ToTable("dbo.Films");
            Property(x => x.MovieName).IsRequired();
            Property(x => x.Content).IsRequired();
            Property(x => x.Director).IsRequired();
            Property(x => x.Actors).IsRequired();


            HasMany(x => x.Likes)
            .WithRequired(x => x.Film)
            .HasForeignKey(x => x.FilmId)
            .WillCascadeOnDelete(false);


            HasMany(x => x.CategoryToFilms)
            .WithRequired(x => x.Film)
            .HasForeignKey(x => x.FilmId)
            .WillCascadeOnDelete(false);

        }
    }
}
