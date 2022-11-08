namespace VelocityTracking.DTO
{
    public class EmployeeDetailsReqeustDTO
    {
        public int EmployeeId { get; set; }
        public string Employee { get; set; } = string.Empty;
        public int EstimatedHours { get; set; }
        public int ActualHours { get; set; }
    }
}
