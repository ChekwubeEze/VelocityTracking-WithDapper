using System.ComponentModel.DataAnnotations;

namespace VelocityTracking.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string ProjectName { get; set; } = string.Empty;
    }
}
