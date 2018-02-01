using Microsoft.EntityFrameworkCore;
using SpiceRack.EntityFrameworkCore.Repository;
using SpiceRack.NetFramework.Example.Model.View;

namespace SpiceRack.NetFramework.Example.DataAccess.Context
{
    public class ExampleViewContext : DatabaseContext
    {
        private const string DatabaseConnectionStringName = "ExampleDatabaseContext";

        public DbSet<Shop> Shop { get; set; }

        public ExampleViewContext()
        {
            DefaultConnectionStringName = DatabaseConnectionStringName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(!string.IsNullOrEmpty(ConnectionString)
                ? ConnectionString
                : new ConnectionStringManager().Get(DefaultConnectionStringName));
        }
    }
}
