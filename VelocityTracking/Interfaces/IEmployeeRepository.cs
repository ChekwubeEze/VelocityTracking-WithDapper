using System.Collections.Generic;
using VelocityTracking.DTO;
using VelocityTracking.Models;

namespace VelocityTracking.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployee();
        string AddEmployee(EmployeeRequestDTO employee);
    }
}
