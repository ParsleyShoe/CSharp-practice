using System;

namespace StringsTutorial {
    class Program {
        static void Main(string[] args) {
            //var st1 = new StringsTutorial();
            //Console.WriteLine(st1.Fullname());
            var denise = new StringsTutorial("Denise", "Bartick");
            Console.WriteLine(denise.Fullname());
        }
    }
}
