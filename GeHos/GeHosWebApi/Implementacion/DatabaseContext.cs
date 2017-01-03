namespace GeHosWebApi
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GeHosContract.Contrato;

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
            modelBuilder.Entity<catAgendaHorario>().HasKey(x => new { x.aghId });
            modelBuilder.Entity<catAlergia>().HasKey(x => new { x.alId });
            modelBuilder.Entity<catCentroDeSalud>().HasKey(x => new { x.csId });
            modelBuilder.Entity<catEspecialidad>().HasKey(x => new { x.espId });
        }

        public System.Data.Entity.DbSet<catAgendaVM> catAgendaVMs { get; set; }
    }

}
