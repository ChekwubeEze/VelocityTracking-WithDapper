using AutoMapper;
using VelocityTracking.DTO;
using VelocityTracking.Models;

namespace VelocityTracking.Profiles
{
    public class MapingProfile: Profile
    {
        public MapingProfile()
        {
            CreateMap<ProjectDetailsRequestDTO, ProjectDetails>();
            CreateMap<EmployeeDetailsReqeustDTO, EmployeeDetails>();
            CreateMap<EmployeeRequestDTO, Employee>();
        }
    }
}
