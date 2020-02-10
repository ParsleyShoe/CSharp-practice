using System;

namespace InClassAssignment {
    class Program {
        static void Main(string[] args) {
            var Majorses = new Major[] {
                new Major(100, "Business Strategy", 1200),
                new Major(200, "Engineering", 1000),
                new Major(300, "Women's Studies", 900),
                new Major(400, "Animal Biology", 1150),
                new Major(500, "Math", 900)
            };
            foreach (var major in Majorses) {
                major.Print();
            }
            var Studentses = new Student[] {
                new Student(1, "Jimberly", "Johnson", 1200, 3.2, Majorses[0]),
                new Student(2, "Cammerzander", "Carlton", 1000, 2.9, Majorses[1]),
                new Student(3, "Kaloway", "Kickett", 1400, 3.5, Majorses[2]),
                new Student(4, "Albert", "Camus", 1200, 3.1, Majorses[3])
            };
            foreach (var student in Studentses) {
                student.Print();
            }
            // new Class(10101, "English", 101, 10);
            // new Class(20201, "Math", 101, 50);
            // new Class(30301, "History", 101, 80);
        }
    }
}
