using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces {
    class AdvWidget : IPrintable {
        public void Print() {
            Console.WriteLine("AdvWidget");
        }
    }
}
