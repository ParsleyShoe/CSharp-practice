using System;
using System.Collections.Generic;

namespace NullableTypes {
    class Program {
        static void Main(string[] args) {
            var studentses = new List<Student>() {
                new Student(1, "Jimothy", "James", 918, 2.9),
                new Student(2, "Constance", "Conrad", 1200, 3.6),
                new Student(3, "Christopher", "Chadwick", 1040, 3.0),
                new Student(4, "Preston", "Peterson", null, 2.8),
                new Student(5, "Taylor", "Tomkins", null, 3.1),
            };
            foreach (var thingy in studentses) {
                thingy.Printy();
            }
        }
    }
}