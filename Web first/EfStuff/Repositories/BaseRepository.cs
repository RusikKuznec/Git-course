using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Web_first.EfStuff.DbModel;


namespace Web_first.EfStuff.Repositories
{
    public class BaseRepository<T> where T : BaseDbModel
    {
        private WebContext _webContext;
        private DbSet<T> _dbSet;

        public BaseRepository(WebContext webContext)
        {
            _webContext = webContext;
            _dbSet = _webContext.Set<T>();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T Get(int id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == id);
        }

        public void Save(T model)
        {
            _dbSet.Add(model);
            _webContext.SaveChanges();
        }

        public void Remove(T model)
        {
            _dbSet.Remove(model);
            _webContext.SaveChanges();
        }






    }
}
