using DataAccess.Data;
using DataAccess.Repository.IRepository;
using Models.Models;
using Models.Repository;

namespace DataAccess.Repository
{
    public class JobApplicationRepository : Repository<JobApplication>, IJobApplicationRepository
    {
        private readonly ApplicationDbContext _db;
        public JobApplicationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(JobApplication obj)
        {
            _db.JobApplications.Update(obj);
        }
    }
}
