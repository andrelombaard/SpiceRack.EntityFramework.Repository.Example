using Microsoft.EntityFrameworkCore;
using SpiceRack.EntityFrameworkCore.Repository;
using SpiceRack.NetFramework.Example.Model.Database;

namespace SpiceRack.NetFramework.Example.DataAccess
{
    public class ExampleDatabaseContext : DatabaseContext
    {
        private const string DatabaseConnectionStringName = "ExampleDatabaseContext";

        public DbSet<Shop> Shop { get; set; }

        public ExampleDatabaseContext()
        {
            DefaultConnectionStringName = DatabaseConnectionStringName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!string.IsNullOrEmpty(ConnectionString))
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
            else
            {
                optionsBuilder.UseSqlServer(new ConnectionStringManager().Get(DefaultConnectionStringName));
            }
        }
    }
}
