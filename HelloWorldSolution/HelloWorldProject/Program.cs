using System;

namespace HelloWorldProject {
    class Program {
        static void Main(string[] args) {

            var s01 = new Student();
            s01.Name = "Parsley";
            s01.FavoriteColor = "Pale purple";
            s01.FavoriteNumber = 69;

            var s02 = new Student();
            s02.Name = "Berry";
            s02.FavoriteColor = "Blue";
            s02.FavoriteNumber = 12;

            var s03 = new Student();
            s03.Name = "Abby";
            s03.FavoriteColor = "Red";
            s03.FavoriteNumber = 20;

            s01.ToConsole();
            s02.ToConsole();
            s03.ToConsole();

            Console.WriteLine("This is my 'Hello World!' program in C#");
            Console.WriteLine("This is another line");

            var counter = 0;
            //counter = "abc";
            if(counter == 0) {
                Console.WriteLine("Counter has no value");
                } else {
                Console.WriteLine("Counter value is " + counter);
                }

            counter = counter + 1;
            Console.WriteLine("Counter value is " + counter);

            counter += 1;
            Console.WriteLine("Counter value is {0}", counter);

            counter++;
            Console.WriteLine($"Counter value is {counter}");

            var sum = 0;
            for (var i = 0; i < 1001; i++) {
                sum += i;
                }
            Console.WriteLine($"The grand total is {sum}!");

            
            }
        }
    }
