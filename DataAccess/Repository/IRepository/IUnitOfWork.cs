namespace DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IJobApplicationRepository JobApplication { get; }
        ITagRepository Tag { get; }
        ICompanyRepository Company { get; }
        IApplicationUserRepository applicationUser { get; }
        void Save();
    }
}
