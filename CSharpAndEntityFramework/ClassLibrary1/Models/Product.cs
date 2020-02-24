using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFLibrary.Models {
    public class Product {
        //[Key]
        public int Id { get; set; }
        //[StringLength(10)]
        //[Required]
        public string Code { get; set; }
        //[StringLength(30)]
        //[Required]
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product() { }

        public override string ToString() => $"{Id} | {Code} | {Name} | {Price}\n";
    }
}
