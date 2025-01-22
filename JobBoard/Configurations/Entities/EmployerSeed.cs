using FullStackProject.Domain;
using Microsoft.EntityFrameworkCore;

namespace Project.Configurations.Entities
{
    public class EmployerSeed : IEntityTypeConfiguration<Employer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employer> builder)
        {
            builder.HasData(
                new Employer
                {
                    Id = 1,
                    FirstName = "Name",
                    LastName = "Name",
                    Email = "Test",
                    Contact = "Test",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    ComapanyID = 1
                }
            );
        }
    }
}
