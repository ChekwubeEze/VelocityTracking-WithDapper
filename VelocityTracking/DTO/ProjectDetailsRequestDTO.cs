namespace VelocityTracking.DTO
{
    public class ProjectDetailsRequestDTO
    {
        public int ProjectId { get; set; }
        public string Projects { get; set; } = string.Empty;
        public string TaskTitle { get; set; } = string.Empty;
        public string TaskDescription { get; set; } = string.Empty;
        public int TotalEstimate { get; set; }
    }
}
