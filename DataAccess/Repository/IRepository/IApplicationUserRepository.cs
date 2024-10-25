using Models.Models;
using Models.Repository.IRepository;

namespace DataAccess.Repository.IRepository
{
    public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
        void Update(ApplicationUser applicationUser);
    }
}
