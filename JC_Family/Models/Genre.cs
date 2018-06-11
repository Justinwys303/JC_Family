using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JC_Family.Models
{
    public class Genre
    {
        public virtual int GenreId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Decription { get; set; }
        public virtual List<Photo> Photos { get; set; }
    }
}