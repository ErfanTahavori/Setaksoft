using Models.Models;
using Models.Repository.IRepository;

namespace DataAccess.Repository.IRepository
{
    public interface ITagRepository : IRepository<Tag>
    {
        public void Update(Tag tag);
    }
}
