using Dapper;
using System.Data.SqlClient;
using VelocityTracking.DTO;
using VelocityTracking.Interfaces;

namespace VelocityTracking.Repositories
{
    public class EmployeeDetailsRepository : IEmployeeDetailsRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string conn;

        public EmployeeDetailsRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            conn = _configuration.GetSection("ConnectionStrings:VelocityTracking").Value;
        }
        public string AddEmployeeDetails(EmployeeDetailsReqeustDTO employeeDetails)
        {
            string message = string.Empty;
            using var connection = new SqlConnection(conn);
            int i = connection.Execute("Insert into EmployeeDetails(EmployeeId, Employee, EstimatedHours, ActualHours) Values(@EmployeeId, @Employee, @EstimatedHours, @ActualHours)", employeeDetails);
            if(i > 0)
            {
                message = "An EmployeeDetails have been added successfully";
            }
            else
            {
                message = "Error";
            }
            return message;
        }
    }
}
