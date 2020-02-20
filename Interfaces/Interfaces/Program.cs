using System;
using System.Collections.Generic;

namespace Interfaces {
    public class Program {
        static void Main(string[] args) {
            Hello hello = new Hello(new English());
            Hello hola = new Hello(new Spanish());
            Hello hallo = new Hello(new German());
            Hello bonjour = new Hello(new French());
            Hello ola = new Hello(new Portuguese());
            Hello konni = new Hello(new Japanese());
            Hello saluton = new Hello(new Esperanto());

            var languages = new List<Hello>() {
                hello, hola, hallo, bonjour, ola, konni, saluton
            };

            foreach (var language in languages) {
                language.Speak();
                Console.WriteLine();
            }
        }
        static void TestInterfaceWidgets() { 
            Widget w1 = new Widget();
            AdvWidget aw = new AdvWidget();
            SuperWidget sw = new SuperWidget();

            List<IPrintable> widgets = new List<IPrintable>() {
                w1, aw, sw
            };

            foreach (IPrintable widge in widgets) {
                widge.Print();
            }
        }
    }
}
