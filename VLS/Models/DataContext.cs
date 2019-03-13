using System.Data.Entity;

namespace VLS.Models
{
	public class DataContext : DbContext
	{
       
        public DataContext()
		{
            DbModelBuilder ModelBuilder = new DbModelBuilder();
            this.Database.Connection.ConnectionString = "server=.;database=VLSDb;trusted_connection=true";
            
           

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Models.Entiteis.Customer>().HasRequired(p => p.Users).WithRequiredPrincipal();
            //modelBuilder.Entity<Models.Entiteis.Users>().HasRequired(p => p.Customer).WithRequiredPrincipal();

        }


        public DbSet<Models.Entiteis.Customer> Customers { get; set; }
		public DbSet<Models.Entiteis.CustomerType> CustomerTypes { get; set; }
		public DbSet<Models.Entiteis.GpsData> GpsData { get; set; }
		public DbSet<Models.Entiteis.Users> Users { get; set; }
		public DbSet<Models.Entiteis.Vehicle> Vehicles { get; set; }
		public DbSet<Models.Entiteis.Vehicletype> Vehicletypes { get; set; }

        


	}
}