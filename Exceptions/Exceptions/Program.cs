using System;

namespace Exceptions {
    class Program {
        static void Main(string[] args) {
            var a = 1;
            var b = 2;

            string x = null;

            try {
                var c = a / (b - b); // tries to divide by 0
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            try {
                var len = x.Length; // tries to get property from null variable
            } catch(NullReferenceException ex) {
                throw new BootcampException("Boot camp exception", ex);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}