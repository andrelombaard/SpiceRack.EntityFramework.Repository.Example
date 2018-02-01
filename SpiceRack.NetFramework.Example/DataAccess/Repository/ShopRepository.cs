using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SpiceRack.EntityFrameworkCore.Repository;
using SpiceRack.NetFramework.Example.DataAccess.Context;
using SpiceRack.NetFramework.Example.Model.Database;
using System.Linq;

namespace SpiceRack.NetFramework.Example.DataAccess.Repository
{
    public class ShopRepository : Repository<Shop, ExampleDatabaseContext, ExampleViewContext>
    {
        public ICollection<Model.View.Shop> Read()
        {
            return ViewContext.Shop.FromSql("EXEC ReadShop").ToList();
        }
    }
}
