using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Cohen451Final.QuestionA
{
    public class DataAccess
    {
        private static string connectionString;

        static DataAccess()
        {
            connectionString = WebConfigurationManager.ConnectionStrings["FinalExam"].ConnectionString;
        }

        public static DataTable selectQuery(string query)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            dt.Load(cmd.ExecuteReader());
            con.Close();

            return dt;
        }

        public static string count(string query)
        {
            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);

            int count = (int)cmd.ExecuteScalar();

            return count.ToString();
        }
    }
}