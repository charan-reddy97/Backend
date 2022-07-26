using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBasics.Entities
{
    public enum DeliveryStatus
    {
        Pending,
        Dispatched,
        OutforDelivery,
        Delivered
    }
    public class Order:Base
    {
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }
    }
}
