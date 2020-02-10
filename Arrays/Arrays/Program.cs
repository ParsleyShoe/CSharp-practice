using System;

namespace Arrays {
    class Program {
        static void Main(string[] args) {
            var RandoNum = new int[5];
            RandoNum[0] = 4797;
            RandoNum[1] = 389;
            RandoNum[2] = 9425967;
            RandoNum[3] = 45069;
            //RandoNum[4] = 1532;
            Console.WriteLine(RandoNum[4]);
            var sumtin = RandoNum[0] + RandoNum[2] + RandoNum[3] - 1475033;
            Console.WriteLine(sumtin);


            // multiply each number 1-10 by 3, and sum all the values
            var sumtin2 = 0;
            var Numberses = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(var num in Numberses) {
                sumtin2 += num * 3;
            }
            Console.WriteLine(sumtin2);

            // 
            var numbies = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var total = 0;
            //var numbies = new int[] { Enumerable.Range(0, 15) };
            foreach (var num in numbies) {
                if (num % 3 == 0 || num % 5 == 0){
                    continue;
                }
                total += num * 3;
            }
            Console.WriteLine($"The answer is {total}");

            //  valid code, but shouldn't be used lol
            //var total=0;foreach(var num in numbies){if(num%2==0){continue;}total+=num*3;}Console.WriteLine(total);
        }
    }
}
