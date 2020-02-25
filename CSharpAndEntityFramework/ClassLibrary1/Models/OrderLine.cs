using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace EFLibrary.Models {
    public class OrderLine {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public virtual Product Product { get; set; }
        [JsonIgnore]
        public virtual Order Order { get; set; }

        public OrderLine() { }

        public override string ToString() => $"{Id} | {OrderId} | {ProductId} | {Quantity}\n";
    }
}
