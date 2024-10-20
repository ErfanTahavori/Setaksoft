using DataAccess.Data;
using DataAccess.Repository.IRepository;
using Models.Models;
using Models.Repository;

namespace DataAccess.Repository
{
    public class TagRepository : Repository<Tag>, ITagRepository
    {
        private readonly ApplicationDbContext _db;
        public TagRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Tag tag)
        {
            _db.Tags.Update(tag);
        }
    }
}
