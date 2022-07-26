﻿using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreBasics.Entities
{
    public class Product :Base
    {
        [Column("ProductName")]
        public string Name { get; set;  }
        {
            return $"{Name}\t{UnitPrice}";
        }
}