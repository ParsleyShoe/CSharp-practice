using System;
using System.Collections.Generic;

namespace PracticeUsingComposition {
    class Program {
        static void Main(string[] args) {
            //var Quantities = new Dictionary<ModelType, int>(3) {
            //    { ModelType.Gold, 9 },
            //    { ModelType.Silver, 7 },
            //    { ModelType.Bronze, 3 }
            //};
            var NewOrder = new List<IProduct>() {
                new GoldWidget(),
                new GoldWidget(),
                new GoldWidget(),
                new GoldWidget(),
                new GoldWidget(),
                new GoldWidget(),
                new GoldWidget(),
                new GoldWidget(),
                new GoldWidget(),
                new SilverWidget(),
                new SilverWidget(),
                new SilverWidget(),
                new SilverWidget(),
                new SilverWidget(),
                new SilverWidget(),
                new SilverWidget(),
                new BronzeWidget(),
                new BronzeWidget(),
                new BronzeWidget()
            };
            double sumtotal = 0;
            foreach (IProduct product in NewOrder) {
                sumtotal += product.GetPrice();
            }
            Console.WriteLine($"The total for the order is {sumtotal.ToString("C")}, my liege.");
        }
    }
}