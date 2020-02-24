using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SQLLibrary {
    public class InstructorController {
        public static BCConnection BCConnection { get; set; }

        public static Instructor LoadInstructorInstance(SqlDataReader reader) {
            var instructor = new Instructor();
            instructor.Id = Convert.ToInt32(reader["Id"]);
            instructor.Firstname = reader["Firstname"].ToString();
            instructor.Lastname = reader["Lastname"].ToString();
            instructor.YearsExperience = Convert.ToInt32(reader["YearsExperience"]);
            instructor.IsTenured = Convert.ToBoolean(reader["IsTenured"]);
            return instructor;
        }
        public static bool ChangeInstructorData(string SQLstatement, Instructor instructor, string change) {
            var command = new SqlCommand(SQLstatement, BCConnection.SQLConnection);
            command.Parameters.AddWithValue("@Id", instructor.Id);
            command.Parameters.AddWithValue("@Firstname", instructor.Firstname);
            command.Parameters.AddWithValue("@Lastname", instructor.Lastname);
            command.Parameters.AddWithValue("@YearsExperience", instructor.YearsExperience);
            command.Parameters.AddWithValue("@IsTenured", instructor.IsTenured);
            var rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected != 1) {
                throw new Exception($"{change} failed.");
            }
            return true;
        }

        public static List<Instructor> GetAllInstructors() {
            var reader = new SqlCommand("SELECT * FROM Instructor", BCConnection.SQLConnection).ExecuteReader();
            if (!reader.HasRows) {
                reader.Close();
                reader = null;
                //Console.WriteLine("No rows returned for GetAllInstructors().");
                return new List<Instructor>();
            }
            var instructors = new List<Instructor>();
            while (reader.Read()) {
                instructors.Add(LoadInstructorInstance(reader));
            }
            reader.Close();
            reader = null;
            return instructors;
        }
        public static Instructor GetInstructorByPK(int id) {
            var command = new SqlCommand("SELECT * FROM Instructor WHERE Id = @Id;");
            command.Parameters.AddWithValue("@Id", id);
            var reader = command.ExecuteReader();
            if (!reader.HasRows) {
                reader.Close();
                reader = null;
                //Console.WriteLine("No instructor was found with that ID.");
                return null;
            }
            var instructor = LoadInstructorInstance(reader);
            reader.Close();
            reader = null;
            return instructor;
        }

        public static bool InsertInstructor(Instructor instructor) {
            var SQLstatement = "INSERT INTO Instructor (Id, Firstname, Lastname, YearsExperience, IsTenured) " +
                               "VALUES (@Id, @Firstname, @Lastname, @YearsExperience, @IsTenured);";
            return ChangeInstructorData(SQLstatement, instructor, "Insert");
        }
        public static bool UpdateInstructor(Instructor instructor) {
            var SQLstatement = "UPDATE Instructor SET " +
                                    "Firstname = @Firstname, " +
                                    "Lastname = @Lastname, " +
                                    "YearsExperience = @YearsExperience, " +
                                    "IsTenured = @IsTenured " +
                                    "WHERE Id = @Id;";
            return ChangeInstructorData(SQLstatement, instructor, "Update");
        }
        public static bool DeleteInstructor(Instructor instructor) {
            var SQLstatement = "DELETE FROM Instructor WHERE Id = @Id;";
            return ChangeInstructorData(SQLstatement, instructor, "Delete");
        }
    }
}
