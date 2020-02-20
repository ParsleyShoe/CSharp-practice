using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces {
    class SuperWidget : IPrintable {
        public void Print() {
            Console.WriteLine("SuperWidget");
        }
    }
}
