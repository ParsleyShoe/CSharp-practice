using System;
using SQLLibrary;

namespace PracticeWithSQL {
    class Program {
        static void Main(string[] args) {
            var SQLLibConn = new BCConnection();
            SQLLibConn.Connect(@"localhost\sqlexpress", "EdDb", "trusted_connection = true");
            StudentController.BCConnection = SQLLibConn;
            MajorController.BCConnection = SQLLibConn;

            var majors = MajorController.GetAllMajors();
            foreach (var major in majors) {
                Console.WriteLine(major);
            }

            var newStudent = new Student {
                Id = 660,
                Firstname = "Timmy",
                Lastname = "Nook",
                SAT = 810,
                GPA = 2.90,
                MajorId = 1
            };
            //Console.WriteLine(StudentController.InsertStudent(newStudent));

            var Students = StudentController.GetAllStudents();
            foreach (Student student in Students) {
                Console.WriteLine(student);
            }

            var studentById = StudentController.GetByPK(100);
            if (studentById == null) {
                Console.WriteLine("Could not find a student with that primary key.");
            } else {
                Console.WriteLine(studentById);
            }

            SQLLibConn.Disconnect();
        }
    }
}