using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    internal class EmployeeTableDaoImplementation : EmployeeTableDao
    {
        public void CreateEmployeeTable(string user, string employeeId)
        {
            // Create Employee Table in Database
            Console.WriteLine($"Employee Table Created for Employee ID: {employeeId}");
        }

        public void DeleteEmployeeTable(string user, string employeeId)
        {
            // Delete Employee Table from Database
            Console.WriteLine($"Employee Table Deleted for Employee ID: {employeeId}");
        }

        public void GetEmployeeTable(string user, string employeeId)
        {
            // Get Employee Table from Database
            Console.WriteLine($"Employee Table Retrieved for Employee ID: {employeeId}");
        }
    }
}
