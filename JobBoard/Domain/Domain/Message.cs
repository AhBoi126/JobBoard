namespace FullStackProject.Domain
{
    public class Message : BaseDomainModel
    {
        public string? MessageContent { get; set; }
        public string? ReadStatus { get; set; }
        public int JobSeekerID { get; set; }
        public int EmployerID { get; set; }
        public int ChatBoxID { get; set; }
    }
}
