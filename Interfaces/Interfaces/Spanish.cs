using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces {
    class Spanish : ISpeakable {
        public void SayHello() {
            Console.WriteLine("Hola");
        }
        public void SayGoodbye() {
            Console.WriteLine("Adiós");
        }
    }
}
