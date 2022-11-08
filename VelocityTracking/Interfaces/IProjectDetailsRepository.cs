using VelocityTracking.DTO;

namespace VelocityTracking.Interfaces
{
    public interface IProjectDetailsRepository
    {
        string AddProjectDetails(ProjectDetailsRequestDTO projectDetails);
    }
}
