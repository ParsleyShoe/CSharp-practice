using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces {
    class Japanese : ISpeakable {
        public void SayHello() {
            Console.WriteLine("こんにちは");
        }
        public void SayGoodbye() {
            Console.WriteLine("さようなら");
        }
    }
}
