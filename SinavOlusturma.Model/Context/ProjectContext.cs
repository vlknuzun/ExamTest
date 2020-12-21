using Microsoft.EntityFrameworkCore;
using SinavOlusturma.Core;
using SinavOlusturma.Model.Entities;
using SinavOlusturma.Model.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace SinavOlusturma.Model.Context
{
    public class ProjectContext : DbContext
    { 

        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Selection> Selections { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<UserExamAnswer> UserExamAnswers { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Selection>()
                .HasOne<Question>(s => s.Question)
                .WithMany(g => g.Selections)
                .HasForeignKey(s => s.QuestionId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<UserExamAnswer>()
               .HasOne<Question>(s => s.Question)
               .WithMany(g => g.UserExamAnswers)
               .HasForeignKey(s => s.QuestionId)
               .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
