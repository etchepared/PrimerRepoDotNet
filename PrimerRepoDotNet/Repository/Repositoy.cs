using Microsoft.EntityFrameworkCore;
using PrimerRepoDotNet.DataAccess;
using PrimerRepoDotNet.Repository.Interfaces;

namespace PrimerRepoDotNet.Repository
{
    public class Repositoy<T> : IRepository<T> where T : class
    {
        protected readonly ContextDB _contextDB;
        public Repositoy(ContextDB contextDB) 
        {
            _contextDB = contextDB;
        }
        public async Task<List<T>> GetAll()
        {
            var entity = await _contextDB.Set<T>().ToListAsync();
            return entity;
        }
    }
}
