using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SQLLibrary {
    public class StudentController {
        public static BCConnection BCConnection { get; set; }

        private static void FeedStudentData(SqlDataReader reader, Student student) {
            student.Id = Convert.ToInt32(reader["Id"]);
            student.Firstname = reader["Firstname"].ToString();
            student.Lastname = reader["Lastname"].ToString();
            student.SAT = Convert.ToInt32(reader["SAT"]);
            student.GPA = Convert.ToDouble(reader["GPA"]);
            //student.MajorId = Convert.ToInt32(reader["MajorId"]);
        }
        private static bool ChangeStudentData(string sqlstatement, Student student, string change) {
            var command = new SqlCommand(sqlstatement, BCConnection.SQLConnection);
            command.Parameters.AddWithValue("@Id", student.Id);
            command.Parameters.AddWithValue("@Firstname", student.Firstname);
            command.Parameters.AddWithValue("@Lastname", student.Lastname);
            command.Parameters.AddWithValue("@SAT", student.SAT);
            command.Parameters.AddWithValue("@GPA", student.GPA);
            command.Parameters.AddWithValue("@MajorId", student.MajorId ?? Convert.DBNull);
            var rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected != 1) {
                throw new Exception($"{change} failed.");
            }
            return true;
        }

        public static List<Student> GetAllStudents() {
            var reader = new SqlCommand("SELECT * FROM Student s " +
                                        "LEFT JOIN Major m ON s.MajorId = m.Id;", BCConnection.SQLConnection).ExecuteReader();
            if (!reader.HasRows) {
                //Console.WriteLine("No rows returned from GetAllStudents()");
                reader.Close();
                return new List<Student>();
            }
            var students = new List<Student>();
            while (reader.Read()) {
                var student = new Student();
                FeedStudentData(reader, student);
                if(Convert.IsDBNull(reader["Description"])) {
                    student.Major = null;
                } else {
                    student.Major = new Major {
                        Description = reader["Description"].ToString(),
                        MinSAT = Convert.ToInt32(reader["MinSat"])
                    };
                }
                students.Add(student);
            }
            reader.Close();
            return students;
        }
        public static Student GetByPK(int id) {
            var reader = new SqlCommand($"SELECT * FROM Student WHERE Id = {id};", BCConnection.SQLConnection).ExecuteReader();
            if (!reader.HasRows) {
                //Console.WriteLine("Nothing found by GetByPK()");
                reader.Close();
                return null;
            }
            reader.Read();
            var student = new Student();
            FeedStudentData(reader, student);
            reader.Close();
            return student;
        }

        public static bool InsertStudent(Student student) {
            //var SQLstatement = "INSERT INTO Student (Id, Firstname, Lastname, SAT, GPA, MajorId) " +
            //                    $"VALUES ({student.Id}, '{student.Firstname}', '{student.Lastname}', " +
            //                    $"{student.SAT}, {student.GPA}, {student.MajorId});";
                                  // writing SQL statements with interpolation is bad practice
            var betterSQLstatement = "INSERT INTO Student (Id, Firstname, Lastname, SAT, GPA, MajorId) " +
                                     $"VALUES (@Id, @Firstname, @Lastname, @SAT, @GPA, @MajorId);";
            return ChangeStudentData(betterSQLstatement, student, "Insert");
        }
        public static bool UpdateStudent(Student student) {
            var SQLstatement = "UPDATE Student SET " +
                                    "Firstname = @Firstname, " +
                                    "Lastname = @Lastname, " +
                                    "SAT = @SAT, " +
                                    "GPA = @GPA, " +
                                    "MajorId = @MajorId " +
                                    "WHERE Id = @Id;";
            return ChangeStudentData(SQLstatement, student, "Update");
        }
        public static bool DeleteStudent(Student student) {
            var SQLstatement = "DELETE FROM Student WHERE Id = @Id";
            return ChangeStudentData(SQLstatement, student, "Delete");
        }
    }
}