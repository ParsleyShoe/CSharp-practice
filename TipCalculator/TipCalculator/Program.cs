using System;
using System.Collections.Generic;

namespace TipCalculator {
    class Program {
        static void Main(string[] args) {
            var bartimeyay = new List<Item> {
                new Item(1, "Vodka Martini", 12.00),
                new Item(1, "Rum and Coke", 8.00),
                new Item(1, "Whiskey", 14.00)
            };
            var regularrestaurant = new List<Item> {
                new Item(1, "Mozzarella Cheesesticks", 6.00),
                new Item(1, "Chicken Parmesan", 14.10),
                new Item(1, "Fettucine Alfredo", 11.29),
                new Item(1, "Extra Fries", 1.89),
                new Item(2, "Coca-Cola", 3.09)
            };

            var subtotal = new Total(bartimeyay, 0.15); // creates a new total instance
            subtotal.GrandTotal(); // returns the grand total calculation

            var subtotal2 = new Total(regularrestaurant, 0.2);
            subtotal2.GrandTotal();
        }
    }
}
// need items (and prices), tax, subtotal, tip amount (to be calculated), grand total