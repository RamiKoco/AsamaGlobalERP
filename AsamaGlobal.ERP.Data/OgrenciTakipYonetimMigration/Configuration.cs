using System.Data.Entity.Migrations;
using AbcYazilim.OgrenciTakip.Data.Contexts;

namespace AbcYazilim.OgrenciTakip.Data.OgrenciTakipYonetimMigration
{
    public class Configuration : DbMigrationsConfiguration<OgrenciTakipYonetimContext>
    {

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

        }
    }
}
