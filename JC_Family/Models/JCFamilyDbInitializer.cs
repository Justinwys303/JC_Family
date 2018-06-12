using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JC_Family.Models
{
    public class JCFamilyDbInitializer:System.Data.Entity.DropCreateDatabaseAlways<JC_FamilyDB>
    {
        protected override void Seed(JC_FamilyDB context)
        {
            //context.Creaters.Add(new Creater { CreaterName = "Justin" });
            //context.Genres.Add(new Genre { Name = "Play" });
            //context.Photos.Add(new Photo
            //{
            //    Creater = new Creater { CreaterName = "Cassie" },
            //    Genre = new Genre { Name = "Study" },
            //    CreatTime = DateTime.Now.ToString(),
            //    Title = "Start"
            //});
            //base.Seed(context);
        }
    }
}