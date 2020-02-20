using System;
using SQLLibrary;

namespace PracticeWithSQL {
    class Program {
        static void Main(string[] args) {
            var SQLLibConn = new BCConnection();
            SQLLibConn.Connect(@"localhost\sqlexpress", "EdDb", "trusted_connection = true");

            StudentController.BCConnection = SQLLibConn;
            var Students = StudentController.GetAllStudents();
            foreach (Student student in Students) {
                Console.WriteLine(student);
            }

            SQLLibConn.Disconnect();
        }
    }
}