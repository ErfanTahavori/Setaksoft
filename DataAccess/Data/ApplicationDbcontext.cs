using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }



        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<JobApplication>()
            .HasOne(j => j.Tag)
            .WithMany(t => t.JobApplications)
            .HasForeignKey(j => j.TagId)
            .OnDelete(DeleteBehavior.Cascade);
            modelbuilder.Entity<ApplicationUser>()
            .HasOne(u => u.Company)
            .WithMany()
            .HasForeignKey(u => u.CompanyId)
            .OnDelete(DeleteBehavior.Cascade);

            modelbuilder.Entity<Company>().HasData(
                 new Company
                 {
                     Id = 1,
                     Name = "Setak Soft",
                     StreetAddress = "Abresan",
                     City = "Tabriz City",
                     PostalCode = "12345",

                     PhoneNumber = "1112223333"
                 },
                new Company
                {
                    Id = 2,
                    Name = "Digikala",
                    StreetAddress = "Valiasr",
                    City = "Tehran City",
                    PostalCode = "13245",

                    PhoneNumber = "1113335555"
                }
                );

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
                    TagId = 1
                }
                );
            modelbuilder.Entity<Tag>().HasData(
                new Tag { Id = 1, Name = "IT" },
                new Tag { Id = 2, Name = "Medical" });


        }
    }
}

