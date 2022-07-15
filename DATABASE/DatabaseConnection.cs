using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE
{
    public class DatabaseConnection
    {
        private SqlConnection myConnection;

        public SqlConnection MyConnection
        {
            get { return myConnection; }
            set { myConnection = value; }
        }

        private SqlCommand myCommand;

        public DatabaseConnection()
        {
            string DBPath = Environment.CurrentDirectory.ToString().Remove(Environment.CurrentDirectory.Length - 9);
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DBPath + @"FOS Database.mdf;Integrated Security=True;Connect Timeout=30";
            myConnection = new SqlConnection(connectionString);
        }

        public void ConnectWithDB()
        {
            myConnection.Open();
        }

        public void CloseConnection()
        {
            myConnection.Close();
        }

        public SqlDataReader GetData(string query)
        {
            myCommand = new SqlCommand(query, myConnection);
            return myCommand.ExecuteReader();
        }

        public int ExecuteSQL(string query)
        {
            myCommand = new SqlCommand(query, myConnection);
            return myCommand.ExecuteNonQuery();
        }
    }
}
