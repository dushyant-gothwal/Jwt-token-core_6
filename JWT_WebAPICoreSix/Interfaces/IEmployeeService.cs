using JWT_WebAPICoreSix.Models;

namespace JWT_WebAPICoreSix.Interfaces
{
    public interface IEmployeeService
    {
        public List<Employee> GetEmployeesDetails();
        public Employee GetEmployeesDetails(int id);
        public Employee AddEmployee(Employee employee);
        public Employee UpdateEmployee(Employee employee);
        public bool DeleteEmployee(int id);
    }
}
