using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLibrary
{
    public class GenericRepository<T> : IGenericRespository<T> where T: class
    {
        private readonly DbContext _context;
        private DbSet<T> table;

        public GenericRepository(DbContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetByID(object Id)
        {
            return table.Find(Id);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate) 
        {
            return table.Where(predicate);
        }

        public void Add(T obj)
        {
            table.Add(obj);
        }
        
        public void AddRange(IEnumerable<T> objs)
        {
            table.AddRange(objs);
        }

        public void Remove(T obj)
        {
            table.Remove(obj);
        }

        public void RemoveRange(IEnumerable<T> objs)
        {
            table.RemoveRange(objs);
        }
    }
}
