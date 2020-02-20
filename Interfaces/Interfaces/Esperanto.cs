using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces {
    class Esperanto : ISpeakable {
        public void SayHello() {
            Console.WriteLine("Saluton");
        }
        public void SayGoodbye() {
            Console.WriteLine("Adiaŭ");
        }
    }
}
