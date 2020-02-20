using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeUsingComposition {
    class SilverWidget : IProduct {
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
        public SilverWidget() {
            Product = new Product() {
                Code = "SW",
                Name = "Silver Widget",
                Model = ModelType.Silver
            };
        }
    }
}