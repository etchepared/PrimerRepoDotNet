using PrimerRepoDotNet.DataAccess;
using PrimerRepoDotNet.Repository;

namespace PrimerRepoDotNet.Services
{
    public class UnitOfWorkService : IUnitOfWork
    {
        private readonly ContextDB _contextDB;
        public UserRepository UserRepository { get; set; }
        public UnitOfWorkService(ContextDB contextDB)
        {
            _contextDB = contextDB;
            UserRepository = new UserRepository(contextDB);
        }

        public Task<int> Complete()
        {
            return _contextDB.SaveChangesAsync();
        }
    }
}
//el unit of work es un intermediario entre el controlador y el repository