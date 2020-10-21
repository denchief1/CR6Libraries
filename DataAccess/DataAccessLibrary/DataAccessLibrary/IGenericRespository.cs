using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLibrary
{
    public interface IGenericRespository<T> where T: class
    {
        IEnumerable<T> GetAll();
        T GetByID(object Id);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void Add(T obj);
        void AddRange(IEnumerable<T> objs);

        void Remove(T obj);
        void RemoveRange(IEnumerable<T> objs);
    }
}
