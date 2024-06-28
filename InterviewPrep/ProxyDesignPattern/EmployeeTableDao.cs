using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    internal interface EmployeeTableDao
    {
        // Create, Delete and Get Methods
        public void CreateEmployeeTable(string user, string employeeId);
        public void DeleteEmployeeTable(string user, string employeeId);
        public void GetEmployeeTable(string user, string employeeId);
    }
}
