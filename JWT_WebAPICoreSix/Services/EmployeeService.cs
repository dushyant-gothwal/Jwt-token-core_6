using JWT_WebAPICoreSix.Interfaces;
using JWT_WebAPICoreSix.Models;

namespace JWT_WebAPICoreSix.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly JwtContext _jwtContext;
        public EmployeeService(JwtContext jwtContext) {

            _jwtContext=jwtContext;
        }    
        public Employee AddEmployee(Employee employee)
        {
            var emp =_jwtContext.Employees.Add(employee);
            _jwtContext.SaveChanges();
            return emp.Entity;
        }

        public bool DeleteEmployee(int id)
        {
            try
            {
                var emp = _jwtContext.Employees.SingleOrDefault(x => x.Id == id);
                if (emp == null)
                {
                    throw new Exception("Not Found");
                }
                else
                {
                    _jwtContext.Employees.Remove(emp);
                    _jwtContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                return false;   
            } 
             
        }

        public List<Employee> GetEmployeesDetails()
        {
            var employee=_jwtContext.Employees.ToList();
            return employee;
        }

        public Employee GetEmployeesDetails(int id)
        {
            var emp = _jwtContext.Employees.SingleOrDefault(x => x.Id == id);
            return emp;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var employeeupdate = _jwtContext.Employees.Update(employee);
            _jwtContext.SaveChanges();
            return employeeupdate.Entity;
        }
    }
}
