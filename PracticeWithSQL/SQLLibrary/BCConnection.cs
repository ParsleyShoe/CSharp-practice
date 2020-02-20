using System;
using System.Data.SqlClient;

namespace SQLLibrary {
    public class BCConnection {
        public SqlConnection SQLConnection { get; set; }
        public void Connect(string server, string database, string authentication) {
            SQLConnection = new SqlConnection($"server={server};database={database};{authentication}");
            SQLConnection.Open();
            if(SQLConnection.State != System.Data.ConnectionState.Open) {
                Console.WriteLine("Could not open the connection; check connection string.");
                SQLConnection = null;
                return;
            }
            Console.WriteLine("Connection successfully opened.  :)");
        }
        public void Disconnect() {
            if(SQLConnection == null) {
                return;
            }
            if(SQLConnection.State == System.Data.ConnectionState.Open) {
                SQLConnection.Close();
                SQLConnection.Dispose();
                SQLConnection = null;
                Console.WriteLine("Connection successfully closed.");
            }
        }
    }
}