using Dapper;
using System.Data.SqlClient;
using VelocityTracking.DTO;
using VelocityTracking.Interfaces;
using VelocityTracking.Models;

namespace VelocityTracking.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string conn;

        public EmployeeRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            conn = _configuration.GetSection("ConnectionStrings:VelocityTracking").Value;
        }
        public string AddEmployee(EmployeeRequestDTO employee)
        {
            string message = string.Empty;
            using var connection = new SqlConnection(conn);
            int i = connection.Execute("Insert into Employee(EmployeeName) Values(@EmployeeName)", employee);
            if (i > 0)
            {
                message = "An EmployeeDetails have been added";
            }
            else
            {
                message = "Error";
            }
            return message;
        }

        public List<Employee> GetAllEmployee()
        {
            using var connection = new SqlConnection(conn);
            var employees = connection.Query<Employee>("Select * From Employee");
            return employees.ToList();
        }
    }
}
