using PrimerRepoDotNet.DataAccess;
using PrimerRepoDotNet.Repository;

namespace PrimerRepoDotNet.Services
{
    public class UnitOfWorkService : IUnitOfWork
    {
        public UserRepository UserRepository { get; set; }
        public UnitOfWorkService(ContextDB contextDB)
        {
            UserRepository = new UserRepository(contextDB);
        }
    }
}
//el unit of work es un intermediario entre el controlador y el repository