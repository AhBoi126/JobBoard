namespace FullStackProject.Domain
{
    public class Application : BaseDomainModel
    {
        public string? Status { get; set; }
        public int JobID { get; set; }
        public int JobSeekerID { get; set; }
        public int ResumeID { get; set; }
    }
}
