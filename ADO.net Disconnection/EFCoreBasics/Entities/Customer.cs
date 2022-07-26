using System.ComponentModel.DataAnnotations;

namespace EFCoreBasics.Entities
{
    public class Customer:Base
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(300)]
        public string Email { get; set; }
        public string ShippingAddress { get; set; }
        public override string ToString()
        {
            return $"{Id}\t{Name}\t{ShippingAddress}";
        }

    }
}
