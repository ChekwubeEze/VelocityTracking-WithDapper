using Dapper;
using System.Data.SqlClient;
using VelocityTracking.DTO;
using VelocityTracking.Interfaces;

namespace VelocityTracking.Repositories
{
    public class ProjectDetailsRepository : IProjectDetailsRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string conn;

        public ProjectDetailsRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            conn = _configuration.GetSection("ConnectionStrings:VelocityTracking").Value;
        }
        public string AddProjectDetails(ProjectDetailsRequestDTO projectDetails)
        {
            string message = string.Empty;
            using var connection = new SqlConnection(conn);
            int i = connection.Execute("Insert into ProjectDetails(ProjectId, Projects, TaskTitle, TaskDescription, TotalEstimate) Values(@ProjectId, @Projects, @TaskTitle, @TaskDescription, @TotalEstimate)", projectDetails);
            if(i > 0)
            {
                message = "A ProjectDetails has been successfully added";
            }
            else
            {
                message = "Error";
            }
            return message;
        }
    }
}
