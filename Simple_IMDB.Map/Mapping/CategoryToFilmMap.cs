using Simple_IMDB.Core.Map;
using Simple_IMDB.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_IMDB.Map.Mapping
{
    public class CategoryToFilmMap: CoreMap<CategoryToFilm>
    {

        public CategoryToFilmMap()
        {
            ToTable("dbo.CategoryToFilm");

            HasRequired(x => x.Category)
                .WithMany(x => x.CategoryToFilms)
                .HasForeignKey(x => x.CategoryId);

            HasRequired(x => x.Film)
                .WithMany(x => x.CategoryToFilms)
                .HasForeignKey(x => x.FilmId);

        }
    }
}
