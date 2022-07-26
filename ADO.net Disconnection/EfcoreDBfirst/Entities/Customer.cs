using System;
using System.Collections.Generic;

#nullable disable

namespace EfcoreDBfirst.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
