namespace FullStackProject.Domain
{
    public class Employer : BaseDomainModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Contact {  get; set; }
        public int ComapanyID { get; set; }
    }
}
