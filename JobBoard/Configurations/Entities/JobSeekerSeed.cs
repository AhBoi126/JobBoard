using FullStackProject.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FullStackProject.Configurations.Entities
{
    public class JobSeekerSeed : IEntityTypeConfiguration<JobSeeker>
    {
        public void Configure(EntityTypeBuilder<JobSeeker> builder)
        {
            builder.HasData(
                new JobSeeker
                {
                    Id = 1,
                    FirstName = "Wei Ming",
                    LastName = "Tan",
                    Email = "weiming.tan@example.com",
                    Contact = "9123-4567",
                    Skills = "C#, ASP.NET, SQL",
                    ProfilePicturePath = "images/wei_ming_tan.jpg",
                    Location = "Tiong Bahru, Singapore",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new JobSeeker
                {
                    Id = 2,
                    FirstName = "Xiu Ying",
                    LastName = "Lim",
                    Email = "xiuying.lim@example.com",
                    Contact = "8123-7654",
                    Skills = "JavaScript, React, Node.js",
                    ProfilePicturePath = "images/xiuying_lim.jpg",
                    Location = "Queenstown, Singapore",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new JobSeeker
                {
                    Id = 3,
                    FirstName = "Ah Huat",
                    LastName = "Chong",
                    Email = "ahhuat.chong@example.com",
                    Contact = "9234-5678",
                    Skills = "Python, Data Science, Machine Learning",
                    ProfilePicturePath = "images/ahhuat_chong.jpg",
                    Location = "Changi, Singapore",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
