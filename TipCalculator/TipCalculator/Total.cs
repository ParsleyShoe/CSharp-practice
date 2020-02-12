using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalculator {
    class Total {
        public double TaxRate = 1.07;
        public double AfterTax;
        public double TipPercentage = 0.15;
        public double GrandTotalWithTip;
        public Total(List<Item> list, double tip) {
            var sum = 0.0;
            foreach (var item in list) {
                sum += (item.Price * item.Quantity);
            }
            AfterTax = sum * TaxRate;
            TipPercentage = tip;
            GrandTotalWithTip = AfterTax + (AfterTax * TipPercentage);
        }
        public void GrandTotal() {
            Console.WriteLine($"Your subtotal (after tax) is ${Math.Round(AfterTax, 2)}.\n" +
                $"If you would like to add a {TipPercentage * 100}% tip, " +
                $"your grand total would be ${Math.Round(GrandTotalWithTip, 2)}!\n");
        }
    }
}
