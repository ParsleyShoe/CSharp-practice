using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeUsingComposition {
    class GoldWidget : IProduct {
        public Product Product { get; set; }
        public double GetPrice() {
            return Product.GetPrice();
        }
        public string GetModel() {
            return Product.GetModel();
        }
        public string GetState() {
            return Product.GetState();
        }
        public GoldWidget() {
            Product = new Product() {
                Code = "GW",
                Name = "Gold Widget",
                Model = ModelType.Gold
            };
        }
    }
}