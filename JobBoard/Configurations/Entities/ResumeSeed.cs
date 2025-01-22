using FullStackProject.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FullStackProject.Configurations.Entities
{
    public class ResumeSeed : IEntityTypeConfiguration<Resume>
    {
        public void Configure(EntityTypeBuilder<Resume> builder)
        {
            builder.HasData(
                new Resume
                {
                    Id = 1,
                    JobSeekerID = 1,  // References JobSeeker with Id 1
                    ResumeFilePath = "resumes/wei_ming_tan_resume.pdf",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Resume
                {
                    Id = 2,
                    JobSeekerID = 2,  // References JobSeeker with Id 2
                    ResumeFilePath = "resumes/xiuying_lim_resume.pdf",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Resume
                {
                    Id = 3,
                    JobSeekerID = 3,  // References JobSeeker with Id 3
                    ResumeFilePath = "resumes/ahhuat_chong_resume.pdf",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
