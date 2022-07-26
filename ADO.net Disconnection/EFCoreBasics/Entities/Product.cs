using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreBasics.Entities
{
    public class Product :Base
    {
        [Column("ProductName")]
        public string Name { get; set;  }        public string Description { get; set; }        public decimal UnitPrice { get; set; }        public int TotalAvailableQuantity { get; set; }        public override string ToString()
        {
            return $"{Name}\t{UnitPrice}";
        }    }
}
