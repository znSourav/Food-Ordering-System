using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Employee
    {
        private string employeeId;
        private string password;
        private string employeeName;
        private double salary;
        private string designation;
        private string employeeUsername;

        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }
        public string EmployeeUsername
        {
            get { return employeeUsername; }
            set { employeeUsername = value; }
        }
    }
}
