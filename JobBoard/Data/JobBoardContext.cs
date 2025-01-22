using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FullStackProject.Domain;

namespace JobBoard.Data
{
    public class JobBoardContext : DbContext
    {
        public JobBoardContext (DbContextOptions<JobBoardContext> options)
            : base(options)
        {
        }

        public DbSet<FullStackProject.Domain.Application> Application { get; set; } = default!;
        public DbSet<FullStackProject.Domain.Bookmark> Bookmark { get; set; } = default!;
        public DbSet<FullStackProject.Domain.Category> Category { get; set; } = default!;
        public DbSet<FullStackProject.Domain.Company> Company { get; set; } = default!;
        public DbSet<FullStackProject.Domain.Employer> Employer { get; set; } = default!;
        public DbSet<FullStackProject.Domain.Job> Job { get; set; } = default!;
        public DbSet<FullStackProject.Domain.JobCategory> JobCategory { get; set; } = default!;
        public DbSet<FullStackProject.Domain.JobSeeker> JobSeeker { get; set; } = default!;
        public DbSet<FullStackProject.Domain.Message> Message { get; set; } = default!;
        public DbSet<FullStackProject.Domain.Resume> Resume { get; set; } = default!;
    }
}
