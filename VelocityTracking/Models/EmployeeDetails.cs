using System.ComponentModel.DataAnnotations;

namespace VelocityTracking.Models
{
    public class EmployeeDetails
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Employee { get; set; } = string.Empty; 
        public int EstimatedHours { get; set; }
        public int ActualHours { get; set; }
    }
}
