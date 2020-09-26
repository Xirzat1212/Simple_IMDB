using Simple_IMDB.Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_IMDB.Model.Entities
{
    public class CategoryToFilm:CoreEntity
    {
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int FilmId { get; set; }

        public virtual Film Film { get; set; }
    }
}
