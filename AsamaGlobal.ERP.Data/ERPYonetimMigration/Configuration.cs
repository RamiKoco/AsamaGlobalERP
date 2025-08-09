using System.Data.Entity.Migrations;
using AsamaGlobal.ERP.Data.Contexts;

namespace AsamaGlobal.ERP.Data.ERPYonetimMigration
{
    public class Configuration : DbMigrationsConfiguration<ERPYonetimContext>
    {

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

        }
    }
}
