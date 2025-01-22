namespace FullStackProject.Domain
{
    public class Resume : BaseDomainModel
    {
        public string? ResumeFilePath { get; set; }
        public int JobSeekerID { get; set; }
    }
}
