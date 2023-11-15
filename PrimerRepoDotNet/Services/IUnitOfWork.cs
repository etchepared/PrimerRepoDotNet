using PrimerRepoDotNet.Repository;

namespace PrimerRepoDotNet.Services
{
    public interface IUnitOfWork
    {
        public UserRepository UserRepository { get; set; }

        public Task<int> Complete();
    }
}
