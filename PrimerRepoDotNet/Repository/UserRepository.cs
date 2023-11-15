using PrimerRepoDotNet.DataAccess;
using PrimerRepoDotNet.Entities;
using Microsoft.EntityFrameworkCore;
using PrimerRepoDotNet.DTOs;
using PrimerRepoDotNet.Services;

namespace PrimerRepoDotNet.Repository
{
    public class UserRepository : Repository<User>
    {

        public UserRepository(ContextDB contextDB) : base(contextDB)
        {
        }

        public virtual async Task<List<User>> GetAllUsers()
        {
            try
            {
            var users = await _contextDB.Users.Where(x => x.IsDeleted == false).ToListAsync();
            return users;
                            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<bool> InsertUser(UserRegisterDTO userRegisterDTO)
        {
            try
            {
                var users = new User();
                users = userRegisterDTO;

                return await base.Insert(users);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
//Lo vamos a utilizar para los filtros