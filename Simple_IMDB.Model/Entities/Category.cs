using Simple_IMDB.Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_IMDB.Model.Entities
{
    public class Category:CoreEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Film> Films { get; set; }

        public virtual ICollection<CategoryToFilm> CategoryToFilms { get; set; }
    }
}
