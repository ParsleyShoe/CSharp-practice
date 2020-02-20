using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeUsingComposition {
    class BronzeWidget : IProduct {
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
        public BronzeWidget() {
            Product = new Product() {
                Code = "BW",
                Name = "Bronze Widget",
                Model = ModelType.Bronze
            };
        }

    }
}