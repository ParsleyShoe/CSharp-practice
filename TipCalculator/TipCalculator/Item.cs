using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalculator {
    class Item {
        public int Quantity;
        public string Description;
        public decimal Price;
        public Item(int quant, string description, decimal price) {
            Description = description;
            Price = price;
            Quantity = quant;
        }
    }
}
