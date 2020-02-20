using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces {
    class Hello {
        ISpeakable Language;
        public void Speak() {
            Language.SayHello();
            Language.SayGoodbye();
        }
        public Hello(ISpeakable language) {
            Language = language;
        }
    }
}
