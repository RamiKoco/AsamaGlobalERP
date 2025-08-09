using System.Data.Entity.Migrations;
using AsamaGlobal.ERP.Data.Contexts;

namespace AsamaGlobal.ERP.Data.ERPMigration
{
   public class Configuration:DbMigrationsConfiguration<ERPContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
