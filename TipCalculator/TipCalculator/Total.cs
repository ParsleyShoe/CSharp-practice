using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalculator {
    class Total {
        public decimal TaxRate = 0.07m;
        public decimal AfterTax;
        public decimal TipPercentage = 0.15m;
        public decimal GrandTotalWithTip;
        public Total(List<Item> list, decimal tip) {
            var sum = 0.00m;
            foreach (var item in list) {
                sum += (item.Price * item.Quantity);
            }
            AfterTax = sum + sum * TaxRate;
            TipPercentage = tip;
            GrandTotalWithTip = AfterTax + AfterTax * TipPercentage;
        }
        public void GrandTotal() {
            Console.WriteLine($"Your subtotal (after tax) is {AfterTax.ToString("C")}.\n" +
                $"If you would like to add a {(TipPercentage).ToString("P")} tip, " +
                $"your grand total would be {GrandTotalWithTip.ToString("C")}!\n");
        }
    }
}
