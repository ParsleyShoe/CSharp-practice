using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFLibrary.Models {
    public class Customer {
        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Name { get; set; }
        public decimal Sales { get; set; }
        public bool Active { get; set; }

        public Customer() { }

        public override string ToString() => $"{Name}\nActive: {Active}\nSales: {Sales}\n";
    }
}
