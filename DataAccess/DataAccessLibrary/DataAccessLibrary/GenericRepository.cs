using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLibrary
{
    /// <summary>
    /// This is the generic implemenation for the IGenericRepository.
    /// </summary>
    /// <typeparam name="T">Type of the Model that you would like the Repository to be.</typeparam>
    public class GenericRepository<T> : IGenericRespository<T>, IDisposable
        where T : class
    {
        /// <value>Injected DB context.</value>
        private readonly DbContext context;

        /// <value>injected DB table.</value>
        private DbSet<T> table;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericRepository{T}"/> class.
        /// </summary>
        /// <param name="context">none generic database context supplied.</param>
        public GenericRepository(DbContext context)
        {
            this.context = context;
            this.table = this.context.Set<T>();
        }

        /// <summary>
        /// Get all of the model types in the db context.
        /// </summary>
        /// <returns>IEnumerable of the model type.</returns>
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        /// <summary>
        /// Get a specific instance of the model from the db by ID.
        /// </summary>
        /// <param name="id">ID of the object.</param>
        /// <returns>instance of model.</returns>
        public T GetByID(object id)
        {
            return table.Find(id);
        }

        /// <summary>
        /// Queryable search of the db context for a list of IEnumerables of the model type.
        /// </summary>
        /// <param name="predicate"> search paramter <c>Where(x => x.matchID == 1)</c>.</param>
        /// <returns>IEnumerable of matching model instances.</returns>
        public IEnumerable<T> Where(Expression<Func<T, bool>> predicate)
        {
            return table.Where(predicate);
        }

        /// <summary>
        /// Add an instance of the model to the DB.
        /// </summary>
        /// <param name="obj">Instance of the model.</param>
        public void Add(T obj)
        {
            table.Add(obj);
            SaveChanges();
        }

        /// <summary>
        /// Add a range of instances to the DB.
        /// </summary>
        /// <param name="objs">IEnumerable of the model.</param>
        public void AddRange(IEnumerable<T> objs)
        {
            table.AddRange(objs);
            SaveChanges();
        }

        /// <summary>
        /// Update an existing instance within the DB.
        /// </summary>
        /// <param name="obj">Instance to update.</param>
        public void Update(T obj)
        {
            context.Attach(obj);
        }

        /// <summary>
        /// Remove an existing instance from the DB.
        /// </summary>
        /// <param name="obj">Instance to remove.</param>
        public void Remove(T obj)
        {
            table.Remove(obj);
            SaveChanges();
        }

        /// <summary>
        /// Remove a range of instances from the DB.
        /// </summary>
        /// <param name="objs">IEnumerable of instances to remove.</param>
        public void RemoveRange(IEnumerable<T> objs)
        {
            table.RemoveRange(objs);
            SaveChanges();
        }

        /// <summary>
        /// Implementation of IDisposable.
        /// </summary>
        public void Dispose()
        {
            context.Dispose();
            GC.SuppressFinalize(this);
            return;
        }

        /// <summary>
        /// Save the changes made to the DB.
        /// </summary>
        private void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
