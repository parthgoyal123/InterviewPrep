namespace ProxyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeTableDao employeeTableDao = new EmployeeTableProxy();
            employeeTableDao.CreateEmployeeTable("admin", "123");
            employeeTableDao.DeleteEmployeeTable("admin", "123");
            employeeTableDao.GetEmployeeTable("admin", "123");

            employeeTableDao.CreateEmployeeTable("user", "123");
            employeeTableDao.DeleteEmployeeTable("user", "123");
            employeeTableDao.GetEmployeeTable("user", "123");
            employeeTableDao.GetEmployeeTable("user1", "123");
        }
    }
}
