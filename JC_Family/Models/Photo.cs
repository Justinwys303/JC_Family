using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JC_Family.Models
{
    public class Photo
    {
        public virtual int PhotoId { get; set; }
        public virtual int GenreId { get; set; }
        public virtual int CreaterId { get; set; }
        [Required]
        [StringLength(60, MinimumLength =3)]
        public virtual string Title { get; set; }
        [Required]
        public virtual string CreatTime { get; set; }
        public virtual string PhotoUrl { get; set; }
        public virtual Creater Creater { get; set; }
        public virtual Genre Genre { get; set; }
    }
}