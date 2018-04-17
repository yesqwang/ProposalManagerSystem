using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProposalManageSystem.Models.Bean {
    public class DatabaseUtil {
        private static string connectionString = "server=(local);user id=sa;password=13361;database=proposal";

        public static SqlConnection getConnection () {
            SqlConnection connection = new SqlConnection(DatabaseUtil.connectionString);
            connection.Open();
            return connection;
        }
        public static void closeConnection (SqlConnection connection) {
            connection.Close();
        }
    }
}