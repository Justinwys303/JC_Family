using JC_Family.Models;
using Microsoft.Owin;
using Owin;
using System.Data.Entity;

[assembly: OwinStartupAttribute(typeof(JC_Family.Startup))]
namespace JC_Family
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //Database.SetInitializer<JC_FamilyDB>(new DropCreateDatabaseIfModelChanges<JC_FamilyDB>());
        }
    }
}
