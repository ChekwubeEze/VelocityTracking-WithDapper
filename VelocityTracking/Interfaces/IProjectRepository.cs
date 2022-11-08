using VelocityTracking.Models;

namespace VelocityTracking.Interfaces
{
    public interface IProjectRepository
    {
        List<Project> GetAllProject();
    }
}
