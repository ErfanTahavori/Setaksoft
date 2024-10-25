using DataAccess.Data;
using DataAccess.Repository.IRepository;

namespace DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork

    {
        private readonly ApplicationDbContext _db;
        public IJobApplicationRepository JobApplication { get; private set; }
        public ITagRepository Tag { get; private set; }
        public ICompanyRepository Company { get; private set; }
        public IApplicationUserRepository applicationUser { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            JobApplication = new JobApplicationRepository(_db);
            Tag = new TagRepository(_db);
            Company = new CompanyRepository(_db);
            applicationUser = new ApplicationUserRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
