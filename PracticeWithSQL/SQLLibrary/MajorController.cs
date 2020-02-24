using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SQLLibrary {
    public class MajorController {
        public static BCConnection BCConnection { get; set; }

        private static Major LoadNewMajorInstance(SqlDataReader reader) {
            var major = new Major();
            major.Id = Convert.ToInt32(reader["Id"]);
            major.Description = reader["Description"].ToString();
            major.MinSAT = Convert.ToInt32(reader["MinSat"]);
            return major;
        }
        private static bool ChangeMajorData(string SQLstatement, Major major, string change) {
            var command = new SqlCommand(SQLstatement, BCConnection.SQLConnection);
            command.Parameters.AddWithValue("@Id", major.Id);
            command.Parameters.AddWithValue("@Description", major.Description);
            command.Parameters.AddWithValue("@MinSAT", major.MinSAT);
            var rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected != 1) {
                throw new Exception($"{change} failed.");
            }
            return true;
        }

        public static List<Major> GetAllMajors() {
            var reader = new SqlCommand("SELECT * FROM Major;", BCConnection.SQLConnection).ExecuteReader();
            if (!reader.HasRows) {
                reader.Close();
                reader = null;
                //Console.WriteLine("No rows found from GetAllMajors().");
                return new List<Major>();
            }
            var majors = new List<Major>();
            while (reader.Read()) {
                majors.Add(LoadNewMajorInstance(reader));
            }
            reader.Close();
            reader = null;
            return majors;
        }
        public static Major GetMajorByPK(int id) {
            var command = new SqlCommand("SELECT * FROM Major WHERE Id = @Id;", BCConnection.SQLConnection);
            command.Parameters.AddWithValue("@Id", id);
            var reader = command.ExecuteReader();
            if (!reader.HasRows) {
                reader.Close();
                reader = null;
                //Console.WriteLine("No major found by that ID.");
                return null;
            }
            var major = LoadNewMajorInstance(reader);
            reader.Close();
            reader = null;
            return major;
        }

        public static bool InsertMajor(Major major) {
            var SQLstatement = "INSERT INTO Major (Id, Description, MinSat) " +
                               "VALUES (@Id, @Description, @MinSAT);";
            return ChangeMajorData(SQLstatement, major, "Insert");
        }
        public static bool UpdateMajor(Major major) {
            var SQLstatement = "UPDATE Major SET " +
                                    "Description = @Description, " +
                                    "MinSat = @MinSAT " +
                                    "WHERE Id = @Id;";
            return ChangeMajorData(SQLstatement, major, "Update");
        }
        public static bool DeleteMajor(Major major) {
            var SQLstatement = "DELETE FROM Major WHERE Id = @Id;";
            return ChangeMajorData(SQLstatement, major, "Delete");
        }
    }
}
