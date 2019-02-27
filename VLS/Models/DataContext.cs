using System.Data.Entity;

namespace VLS.Models
{
	public class DataContext : DbContext
	{
		public DataContext()
		{
			this.Database.Connection.ConnectionString = "server=.;database=VLSDb;trusted_connection=true";
		}
		public DbSet<Models.Entiteis.Customer> Customers { get; set; }
		public DbSet<Models.Entiteis.CustomerType> CustomerTypes { get; set; }
		public DbSet<Models.Entiteis.GpsData> GpsData { get; set; }
		public DbSet<Models.Entiteis.Users> Users { get; set; }
		public DbSet<Models.Entiteis.Vehicle> Vehicles { get; set; }
		public DbSet<Models.Entiteis.Vehicletype> Vehicletypes { get; set; }


	}
}