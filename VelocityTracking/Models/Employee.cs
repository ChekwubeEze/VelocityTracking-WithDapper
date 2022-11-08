using System.ComponentModel.DataAnnotations;

namespace VelocityTracking.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
    }
}
