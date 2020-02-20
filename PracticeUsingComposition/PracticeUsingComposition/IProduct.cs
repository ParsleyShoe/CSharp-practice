using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeUsingComposition {
    interface IProduct {
        public double GetPrice();
        public string GetModel();
        public string GetState();
    }
}