using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SQLLibrary {
    public class StudentController {
        public static BCConnection BCConnection { get; set; }
        public static List<Student> GetAllStudents() {
            var reader = new SqlCommand("SELECT * FROM Student", BCConnection.SQLConnection).ExecuteReader();
            if (!reader.HasRows) {
                Console.WriteLine("No rows returned from GetAllStudents()");
                return new List<Student>();
            }
            var students = new List<Student>();
            while (reader.Read()) {
                var student = new Student();
                student.Id = Convert.ToInt32(reader["Id"]);
                student.Firstname = reader["Firstname"].ToString();
                student.Lastname = reader["Lastname"].ToString();
                student.SAT = Convert.ToInt32(reader["SAT"]);
                student.GPA = Convert.ToDouble(reader["GPA"]);
                //student.MajorId = Convert.ToInt32(reader["MajorId"]);
                students.Add(student);
            }
            return students;
        }
        public static Student GetByPK(int id) {

        }
    }
}