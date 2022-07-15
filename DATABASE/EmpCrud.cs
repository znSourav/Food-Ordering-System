using System;
using ENTITY;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE
{
    public class EmpCrud
    {
        public bool EmpLoginVerification(string username, string password)
        {
            string query = "SELECT * from Employee WHERE Username= '" + username + "' AND Password= '" + password + "'";
            DatabaseConnection dbc = new DatabaseConnection();
            dbc.ConnectWithDB();
            SqlDataReader sdr = dbc.GetData(query);

            if (sdr.Read())
            {
                dbc.CloseConnection();
                return true;
            }
            else
            {
                dbc.CloseConnection();
                return false;
            }
        }

        public Employee GetEmployee(string username)
        {
            string query = "SELECT * from Employee WHERE Username= '" + username + "'";
            Employee emp = null;
            DatabaseConnection dbc = new DatabaseConnection();
            dbc.ConnectWithDB();
            SqlDataReader sdr = dbc.GetData(query);
            if (sdr.Read())
            {
                emp = new Employee();
                emp.EmployeeId = sdr["ID"].ToString();
                emp.Password = sdr["Password"].ToString();
                emp.EmployeeName = sdr["Name"].ToString();
                emp.EmployeeUsername = username;
                emp.Salary = Convert.ToDouble(sdr["Salary"]);
                emp.Designation = sdr["Designation"].ToString();
            }
            dbc.CloseConnection();
            return emp;
        } 
    }
}
