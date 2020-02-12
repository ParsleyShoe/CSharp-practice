using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalculator {
    class Item {
        public string Description;
        public double Price;
        public Item(string description, double price) {
            Description = description;
            Price = price;
        }
    }
}
