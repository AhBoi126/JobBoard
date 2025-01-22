namespace FullStackProject.Domain
{
    public class Company : BaseDomainModel
    {
        public string? CompanyName { get; set; }
        public string? Industry { get; set; }
        public string? Location { get; set; }
        public string? Website { get; set; }
        public string? CompanyDescription { get; set; }
        public string? CompanyLogoPath { get; set; }
    }
}
