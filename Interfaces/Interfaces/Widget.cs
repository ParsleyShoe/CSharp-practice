using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces {
    class Widget : IPrintable {
        public void Print() {
            Console.WriteLine("Widget");
        }
    }
}
