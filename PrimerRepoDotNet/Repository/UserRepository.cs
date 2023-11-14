using PrimerRepoDotNet.DataAccess;
using PrimerRepoDotNet.Entities;
using Microsoft.EntityFrameworkCore;

namespace PrimerRepoDotNet.Repository
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(ContextDB contextDB) : base(contextDB)
        {
        }

        public virtual async Task<List<User>> GetAllUsers()
        {
            var users = await _contextDB.Users.ToListAsync();
            return users;
        }
    }
}
//Lo vamos a utilizar para los filtros