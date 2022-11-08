using System.ComponentModel.DataAnnotations;

namespace VelocityTracking.Models
{
    public class ProjectDetails
    {
        [Key]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Projects { get; set; } = string.Empty;
        public string TaskTitle { get; set; } = string.Empty ;
        public string TaskDescription { get; set; } = string .Empty ;
        public int TotalEstimate { get; set; }  

    }
}
