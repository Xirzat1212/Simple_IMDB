using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_IMDB.Model.Entities
{
    public class Like
    {
        public int FilmId { get; set; }
        public virtual Film Film { get; set; }
        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
