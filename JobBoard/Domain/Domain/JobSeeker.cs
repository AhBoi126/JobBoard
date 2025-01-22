namespace FullStackProject.Domain
{
    public class JobSeeker:BaseDomainModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Contact { get; set; }
        public string? Skills { get; set; }
        public string? ProfilePicturePath { get; set; }
        public string? Location { get; set; }
    }
}
