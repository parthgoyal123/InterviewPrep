using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    internal class EmployeeTableProxy : EmployeeTableDao
    {
        private EmployeeTableDaoImplementation employeeTableDaoImplementation;
        
        public EmployeeTableProxy()
        {
            this.employeeTableDaoImplementation = new EmployeeTableDaoImplementation();
        }

        public void CreateEmployeeTable(string user, string employeeId)
        {
            // Check if user is authorized to create Employee Table
            if (user == "admin")
            {
                this.employeeTableDaoImplementation.CreateEmployeeTable(user, employeeId);
            }
            else
            {
                Console.WriteLine("User is not authorized to create Employee Table");
            }
        }

        public void DeleteEmployeeTable(string user, string employeeId)
        {
            // Check if user is authorized to delete Employee Table
            if (user == "admin")
            {
                this.employeeTableDaoImplementation.DeleteEmployeeTable(user, employeeId);
            }
            else
            {
                Console.WriteLine("User is not authorized to delete Employee Table");
            }
        }

        public void GetEmployeeTable(string user, string employeeId)
        {
            // Check if user is authorized to get Employee Table
            if (user == "admin" || user == "user")
            {
                this.employeeTableDaoImplementation.GetEmployeeTable(user, employeeId);
            }
            else
            {
                Console.WriteLine("Unknown User trying to get Employee Data");
            }
        }
    }
}
