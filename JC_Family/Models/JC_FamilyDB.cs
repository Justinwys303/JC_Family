using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JC_Family.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class JC_FamilyDB : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public JC_FamilyDB() : base("name=JC_FamilyDB")
        {
            //Database.SetInitializer(new JCFamilyDbInitializer());
        }

        public System.Data.Entity.DbSet<JC_Family.Models.Photo> Photos { get; set; }

        public System.Data.Entity.DbSet<JC_Family.Models.Creater> Creaters { get; set; }

        public System.Data.Entity.DbSet<JC_Family.Models.Genre> Genres { get; set; }
    }
}
