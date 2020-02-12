using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalculator {
    class Item {
        public int Quantity;
        public string Description;
        public double Price;
        public Item(int quant, string description, double price) {
            Description = description;
            Price = price;
            Quantity = quant;
        }
    }
}
