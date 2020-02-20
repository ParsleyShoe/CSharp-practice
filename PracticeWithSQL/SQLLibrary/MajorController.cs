using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SQLLibrary {
    public class MajorController {
        public static BCConnection BCConnection { get; set; }

        private static void FeedMajorData(SqlDataReader reader, Major major) {
            major.Id = Convert.ToInt32(reader["Id"]);
            major.Description = reader["Description"].ToString();
            major.MinSAT = Convert.ToInt32(reader["MinSat"]);
        }

        public static List<Major> GetAllMajors() {
            var reader = new SqlCommand("SELECT * FROM Major", BCConnection.SQLConnection).ExecuteReader();
            if (!reader.HasRows) {
                reader.Close();
                reader = null;
                Console.WriteLine("No rows found from GetAllMajors().");
                return new List<Major>();
            }
            var majors = new List<Major>();
            while (reader.Read()) {
                var major = new Major();
                FeedMajorData(reader, major);
                majors.Add(major);
            }
            reader.Close();
            reader = null;
            return majors;
        }
    }
}
