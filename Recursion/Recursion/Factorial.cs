

namespace Recursion {
    class Factorial {
        public static int CalcFactorial(int n) {
            if (n == 1) {
                return 1;
            }
            return n * CalcFactorial(n - 1);
        }
    }
}