using Simple_IMDB.Core.Entity.Concrete;
using Simple_IMDB.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_IMDB.Model.Entities
{
    public class AppUser:CoreEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }


        public string ImagePath { get; set; }
        public string UserImage { get; set; }
        public string XSmallUserImage { get; set; }
        public string CruptedUserImage { get; set; }


        public virtual ICollection<Film> Films { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
    }
}
