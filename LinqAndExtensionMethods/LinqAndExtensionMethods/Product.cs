﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndExtensionMethods {
    public class Product {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool Taxible { get; set; }
    }
}
