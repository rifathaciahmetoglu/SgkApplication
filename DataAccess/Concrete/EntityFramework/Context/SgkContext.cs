using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class SgkContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.; Database=SgkApp;TrustServerCertificate=True; Trusted_Connection=true");
        }
        public DbSet<Company>? Companies { get; set; }
        public DbSet<Contract>? Contracts { get; set; }
        public DbSet<Document>? Documents { get; set; }
        public DbSet<Note>? Notes { get; set; }
        public DbSet<ProfessionalPracticeTraining>? ProfessionalPracticeTraining { get; set; }
        public DbSet<Staff>? Staffs { get; set; }
        public DbSet<StaffEducations>? StaffEducations { get; set; }
        public DbSet<StaffJob>? StaffJobs { get; set; }
        public DbSet<UserLog>? UserLogs { get; set; }
    }
}
