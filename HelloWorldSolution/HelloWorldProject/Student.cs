using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldProject {
    class Student {
        public string FavoriteColor;
        public int FavoriteNumber;
        public string Name;

        public void ToConsole() {
            Console.WriteLine($"Name is {Name}, Color is {FavoriteColor}, Number is {FavoriteNumber}");
            }
        }
    }
