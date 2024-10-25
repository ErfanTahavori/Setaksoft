using Models.Models;
using Models.Repository.IRepository;

namespace DataAccess.Repository.IRepository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company company);
    }
}
