using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ChapeauModel;

namespace ChapeauDAL
{
    public class EmployeeDao : BaseDao
    {
        public Employee GetEmployee(string username, string password)
        {
            string query = $"SELECT employeeID, name, role, password FROM Employee WHERE employeeID = '{username}' AND [password] = '{password}'";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Employee> employees = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            if (employees.Count == 0)
            {
                return null;
            }
            else
            {
                return employees[0];
            }
        }

        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Employee employee = new Employee();

                employee.EmployeeID = (int)(dr["employeeID"]);
                employee.Name = (string)(dr["name"]);
                employee.Role = (Role)(dr["role"]);
                employee.Password = (string)(dr["password"]);

                employees.Add(employee);
            }

            return employees;
        }
    }
}
