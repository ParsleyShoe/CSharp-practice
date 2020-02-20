using System;

namespace Recursion {
    class Program {
        static void Main(string[] args) {
            int N = 15;
            Console.WriteLine($"{N}! = {Factorial.CalcFactorial(N)}"); // writes the factorial of variable N

            int X = 22;
            Console.WriteLine($"{Fibonacci.CalcFibonacci(X)} is the number at place {X} in the Fibonacci sequence.");
        }
    }
}