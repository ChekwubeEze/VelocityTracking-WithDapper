using Dapper;
using System.Data.SqlClient;
using VelocityTracking.Interfaces;
using VelocityTracking.Models;

namespace VelocityTracking.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string conn;

        public ProjectRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            conn = _configuration.GetSection("ConnectionStrings:VelocityTracking").Value;
        }
        public List<Project> GetAllProject()
        {
            List<Project> projects = new List<Project>();
            using var connection = new SqlConnection(conn);
            projects = connection.Query<Project>("Select * From Project").ToList();
            return projects;
        }
    }
}
