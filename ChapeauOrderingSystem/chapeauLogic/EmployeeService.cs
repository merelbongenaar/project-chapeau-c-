using System;
using System.Collections.Generic;
using System.Text;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class EmployeeService
    {
        EmployeeDao employeedb;

        public EmployeeService()
        {
            employeedb = new EmployeeDao();
        }

        public Employee GetEmployee(string username, string password)
        {
            Employee employee = employeedb.GetEmployee(username, password);
            return employee;
        }
    }
}
