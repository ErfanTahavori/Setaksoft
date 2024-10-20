using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }



        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<JobApplication>()
           .HasMany(j => j.Tags)
           .WithMany(t => t.JobApplications)
           .UsingEntity(jt => jt.ToTable("JobApplicationTags"));

            modelbuilder.Entity<JobApplication>().HasData(
                new JobApplication
                {
                    Id = 1,
                    Title = "First job",
                    Cooperation_Type = JobApplication.CooperationType.FullTime,
                    City = JobApplication.CityEnum.Tehran,
                    Sex = JobApplication.SexEnum.Male,
                    Military_Status = JobApplication.MilitaryStatus.EducationalExemption,
                    Last_Degree = JobApplication.LastDegree.BachelorDegree,
                    Negotiated_Salary = false,
                    Start_Salary = 150000,
                    End_Salary = 250000,
                    Work_Experience = 12,
                    Description = " we are searching for an asp.net developer  \n skills Required: c#, asp.net, sql server, Ef core, web api, Design Patterns, Clean Architecture \n Other benefits\r\nFixed salary\r\nProfessional training to improve skills (training is free)\r\nDynamic and friendly work environment\r\nThe possibility of career advancement and promotion in the company ",
                    IsAccepted = true,
                }
                );
            modelbuilder.Entity<Tag>().HasData(
                new Tag { Id = 1, Name = "IT" },
                new Tag { Id = 2, Name = "Medical" });

            modelbuilder.Entity("JobApplicationTag").HasData(
            new { JobApplicationsId = 1, TagsId = 1 },
            new { JobApplicationsId = 1, TagsId = 2 }
        );


        }




    }
}

