using Models.Models;
using Models.Repository.IRepository;

namespace DataAccess.Repository.IRepository
{
    public interface IJobApplicationRepository : IRepository<JobApplication>
    {
        void Update(JobApplication obj);
    }
}
