using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VelocityTracking.DTO;
using VelocityTracking.Interfaces;
using VelocityTracking.Models;

namespace VelocityTracking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VelocityTrackingController : ControllerBase
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IProjectDetailsRepository _projectDetailsRepository;
        private readonly IEmployeeDetailsRepository _employeeDetailsRepository;
        private readonly IEmployeeRepository _employeeRepository;

        public VelocityTrackingController(IProjectRepository projectRepository, IProjectDetailsRepository projectDetailsRepository, IEmployeeDetailsRepository employeeDetailsRepository, IEmployeeRepository employeeRepository)
        {
            _projectRepository = projectRepository;
            _projectDetailsRepository = projectDetailsRepository;
            _employeeDetailsRepository = employeeDetailsRepository;
            _employeeRepository = employeeRepository;
        }
        [HttpGet("Get-All-Projects")]
        public List<Project> GetAllProject()
        {
           var projects = _projectRepository.GetAllProject();
            return projects;
        }
        [HttpPost("Add-ProjectDetails")]
        public string AddProjectDetails([FromQuery]ProjectDetailsRequestDTO projectDetails)
        {
            return _projectDetailsRepository.AddProjectDetails(projectDetails);
        }
        [HttpPost("Add-EmployeeDetails")]
        public string AddEmployeeDetails([FromQuery]EmployeeDetailsReqeustDTO employeeDetails)
        {
            return _employeeDetailsRepository.AddEmployeeDetails(employeeDetails);
        }
        [HttpPost("Add-Employee")]
        public string AddEmployee([FromQuery]EmployeeRequestDTO employee)
        {
            return _employeeRepository.AddEmployee(employee);
        }
        [HttpGet("Get- All-Employee")]
        public List<Employee> GetAllEmployee()
        {
            return _employeeRepository.GetAllEmployee();
        }

    }
}
