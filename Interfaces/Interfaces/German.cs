using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces {
    class German : ISpeakable {
        public void SayHello() {
            Console.WriteLine("Hallo");
        }
        public void SayGoodbye() {
            Console.WriteLine("Auf Wiedersehen");
        }
    }
}
