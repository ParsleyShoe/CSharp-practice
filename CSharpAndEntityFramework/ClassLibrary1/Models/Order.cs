using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFLibrary.Models {
    public class Order {
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<OrderLine> OrderLines { get; set; }

        public Order() { }

        public override string ToString() => $"{Description}\nAmount: {Amount}\n";
    }
}
