namespace GeHos.Models
{
    using DB;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class DatabaseContext : DbContext
	{
		public DatabaseContext()
            : base("name=MSP_GeDoc")
		{

		}

        public DatabaseContext(string audit)
            : base("name=DefaultConnectionAudit")
        {

        }

		public DatabaseContext(bool ProxyCreationEnabled)
            : base("name=DefaultConnection")
		{
			this.Configuration.ProxyCreationEnabled = false;
		}
		

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Entity<catAgenda>().ToTable("catAgenda");
            modelBuilder.Entity<catAgenda>().HasKey(x => new { x.agId  });
        }

        public System.Data.Entity.DbSet<GeHos.Models.catAgendaVM> catAgendaVMs { get; set; }
    }

}
