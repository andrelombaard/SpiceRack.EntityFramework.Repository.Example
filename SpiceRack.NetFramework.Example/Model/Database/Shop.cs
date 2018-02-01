using System.ComponentModel.DataAnnotations.Schema;

namespace SpiceRack.NetFramework.Example.Model.Database
{
    public class Shop
    {
        public int ShopId { get; set; }
        public string Name { get; set; }

        [ForeignKey("Area"), Column("AreaId")]
        public int AreaId { get; set; }
        public Area Area { get; set; }
    }
}
