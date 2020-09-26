using Simple_IMDB.Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_IMDB.Model.Entities
{
    public class Film:CoreEntity
    {
        public string MovieName { get; set; }
        public string Content { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string ImagePath { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        public virtual ICollection<CategoryToFilm> CategoryToFilms { get; set; }
    }
}
