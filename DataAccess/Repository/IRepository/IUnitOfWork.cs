namespace DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IJobApplicationRepository JobApplication { get; }
        ITagRepository Tag { get; }
        void Save();
    }
}
