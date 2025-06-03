using System;
using System.Data;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayipHayvanTakipSistemi
{
    internal class DBSource
    {
        private static string connectionString = "Server=LAPTOP-34O7JF87\\SQLEXPRESS;Database=HayvanTakipDB;Intergrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection (connectionString);
        }
        public static DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load (reader);
            }
            return dt;
        }
        public static int ExecuteNonQuery(string commandText)
        {
            using(SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(commandText, conn);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
