using FullStackProject.Domain;
using Microsoft.EntityFrameworkCore;

namespace Project.Configurations.Entities
{
    public class JobCategorySeed : IEntityTypeConfiguration<JobCategory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<JobCategory> builder)
        {
            builder.HasData(
                new JobCategory
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    CategoryID = 1 
                }
            );
        }
    }
}
