using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using backend.model.teacherModels;

namespace backend.data
{
    public class AppDB : DbContext
    {
        public AppDB(DbContextOptions<AppDB> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeacherAccount>().ToTable("TeacherAccounts");
            modelBuilder.Entity<TeacherData>().ToTable("TeacherData");
            modelBuilder.Entity<TeacherCertificates>().ToTable("TeacherCertificates");

            // Configure relationships
            modelBuilder.Entity<TeacherAccount>()
                .HasOne(t => t.TeacherData)
                .WithOne(td => td.TeacherAccount)
                .HasForeignKey<TeacherData>(td => td.TeacherAccountId);

            modelBuilder.Entity<TeacherData>()
                .HasMany(td => td.Certificates)
                .WithOne(tc => tc.TeacherData)
                .HasForeignKey(tc => tc.TeacherDataId);
        }

        public DbSet<TeacherAccount> TeacherAccounts { get; set; }
        public DbSet<TeacherData> TeacherData { get; set; }
        public DbSet<TeacherCertificates> TeacherCertificates { get; set; }
        
    }
}