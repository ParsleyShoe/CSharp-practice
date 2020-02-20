using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces {
    class Portuguese : ISpeakable {
        public void SayHello() {
            Console.WriteLine("Olá");
        }
        public void SayGoodbye() {
            Console.WriteLine("Adeus");
        }
    }
}
