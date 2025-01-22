using FullStackProject.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Project.Configurations.Entities
{
    public class JobSeed : IEntityTypeConfiguration<Job>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Job> builder)
        {
            builder.HasData(
               new Job
               {
                   Id = 1,
                   JobTitle = "Test",
                   JobDescription = "Test",
                   Requirements = "Test",
                   Salary = "Test",
                   Location = "Test",
                   Status = "Test",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System",
                   EmployerID = 1,
                   JobCategoryID = 1
               }
            );
        }
    }
}
