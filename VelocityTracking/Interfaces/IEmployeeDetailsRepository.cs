using VelocityTracking.DTO;

namespace VelocityTracking.Interfaces
{
    public interface IEmployeeDetailsRepository
    {
        string AddEmployeeDetails(EmployeeDetailsReqeustDTO employeeDetails);
    }
}
