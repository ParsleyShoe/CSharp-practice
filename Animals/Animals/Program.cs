using System;
using AnimalLibrary;
using System.Collections.Generic;

namespace Animals {
    class Program {
        static void Main(string[] args) {
            var pug1 = new Pug();
            var Boxie = new Boxer();
            var germanshepherd = new GermanShepherd() {
                BarkPitch = BarkPitch.Low,
                ExtremeSenseOfSmell = true,
                Name = "Killer"
            };
            var pug = new Dog() {
                LongTail = false,
                BarkPitch = BarkPitch.High,
                Muzzle = MuzzleType.Collapsed,
                ExtremeSenseOfSmell = false,
                Name = "Ralph"
            };
            var spudsy = new Pug() {
                BarkPitch = BarkPitch.High,
                Name = "Spudsy",
                CurlyTail = true,
                SmallDog = true
            };

            var ListOfDogs = new List<Dog>();
            ListOfDogs.Add(pug1);
            ListOfDogs.Add(Boxie);
            ListOfDogs.Add(germanshepherd);
            ListOfDogs.Add(pug);
            ListOfDogs.Add(spudsy);
            foreach (var item in ListOfDogs) {
                Console.WriteLine(item);
            }
        }
    }
}