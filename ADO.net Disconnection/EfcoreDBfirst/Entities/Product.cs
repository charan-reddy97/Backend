using System;
using System.Collections.Generic;

#nullable disable

namespace EfcoreDBfirst.Entities
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int TotalAvailableQuantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
