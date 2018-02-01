using Microsoft.EntityFrameworkCore;
using SpiceRack.EntityFrameworkCore.Repository;
using SpiceRack.NetFramework.Example.Model.Database;

namespace SpiceRack.NetFramework.Example.DataAccess
{
    public class ExampleDatabaseContext : DatabaseContext
    {
        private const string DatabaseConnectionStringName = "ExampleDatabaseContext";

        public DbSet<Area> Area { get; set; }

        public DbSet<Shop> Shop { get; set; }

        public ExampleDatabaseContext()
        {
            DefaultConnectionStringName = DatabaseConnectionStringName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(!string.IsNullOrEmpty(ConnectionString)
                ? ConnectionString
                : new ConnectionStringManager().Get(DefaultConnectionStringName));
        }

        public override void SeedProductionData()
        {
            Area.AddRange
                (
                    new Area
                    {
                        Name = "Johannesburg"
                    },
                    new Area
                    {
                        Name = "Pretoria"
                    },
                    new Area
                    {
                        Name = "Cape Town"
                    }
                );

            SaveChanges();
        }

        public override void SeedDebugData()
        {
            Shop.AddRange
                (
                    new Shop
                    {
                        Name = "Example Shop 1",
                        AreaId = 1
                    },
                    new Shop
                    {
                        Name = "Example Shop 2",
                        AreaId = 1 
                    },
                    new Shop
                    {
                        Name = "Example Shop 3",
                        AreaId = 2
                    },
                    new Shop
                    {
                        Name = "Example Shop 4",
                        AreaId = 3
                    }
                );

            SaveChanges();
        }
    }
}
