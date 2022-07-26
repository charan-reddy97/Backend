using System;
using System.ComponentModel.DataAnnotations;
namespace EFCoreBasics.Entities
{
   public abstract class Base
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
