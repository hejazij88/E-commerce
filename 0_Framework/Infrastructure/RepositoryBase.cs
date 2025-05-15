using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Domain;
using Microsoft.EntityFrameworkCore;

namespace _0_Framework.Infrastructure
{
    public class RepositoryBase<TKey,T>:IRepository<TKey,T> where T : class
    {

        private readonly DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public T? Get(TKey key) => _context.Find<T>(key);

        public List<T> Get() => _context.Set<T>().ToList();

        public void Create(T entity) => _context.Add(entity);

        public void SaveChanges() => _context.SaveChanges();

    }
}
