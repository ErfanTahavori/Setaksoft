using DataAccess.Data;
using DataAccess.Repository.IRepository;
using Models.Models;
using Models.Repository;

namespace DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Company company)
        {
            _db.Companies.Update(company);
        }
    }
}
