using AsamaGlobal.ERP.Data.ERPYonetimMigration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using AsamaGlobal.ERP.Model.Entities;

namespace AsamaGlobal.ERP.Data.Contexts
{
    public class ERPYonetimContext : BaseDbContext<ERPYonetimContext,Configuration>
    {

        public ERPYonetimContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public ERPYonetimContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

        }

        public DbSet<Kurum> Kurum { get; set; }

    }
}
