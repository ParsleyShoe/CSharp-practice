using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFLibrary.Models {
    public class Product {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual List<OrderLine> OrderLines { get; set; }

        public Product() { }

        public override string ToString() => $"{Id} | {Code} | {Name} | {Price}\n";
    }
}
