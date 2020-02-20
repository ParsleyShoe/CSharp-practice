using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeUsingComposition {
    public enum ModelType { Bronze, Silver, Gold };
    
    public class Product {

        public string Code { get; set; }
        public string Name { get; set; }
        public ModelType Model { get; set; }
        
        public double GetPrice() {
            return Model switch
            {
                ModelType.Bronze => 20,
                ModelType.Silver => 90,
                ModelType.Gold => 500,
                _ => 0
            };
        }

        public string GetModel() {
            return Model switch
            {
                ModelType.Bronze => "Bronze",
                ModelType.Silver => "Silver",
                ModelType.Gold => "Gold",
                _ => "Not found..."
            };
        }

        public string GetState() {
            return Model switch
            {
                ModelType.Bronze => "Kentucky",
                ModelType.Silver => "Indiana",
                ModelType.Gold => "Ohio",
                _ => "No state found..."
            };
        }

        public Product() { }
    }
}