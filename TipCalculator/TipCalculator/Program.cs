using System;
using System.Collections.Generic;

namespace TipCalculator {
    class Program {
        static void Main(string[] args) {
            var Items = new List<Item> {
                new Item("Vodka Martini", 12.00),
                new Item("Rum and Coke", 8.00),
                new Item("Whiskey", 14.00)
            };
            var SubTotal = 21.34;
        }
    }
}
// need items (and prices), tax, subtotal, tip amount (to be calculated), grand total