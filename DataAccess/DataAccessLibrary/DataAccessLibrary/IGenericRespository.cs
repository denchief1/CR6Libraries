using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLibrary
{
    /// <summary>
    /// Interface for a generic repoistory.
    /// </summary>
    /// <typeparam name="T">Type of Instance of the Repository.</typeparam>
    public interface IGenericRespository<T>
        where T : class
    {
        /// <summary>
        /// Get all of the model types in the db context.
        /// </summary>
        /// <returns>IEnumerable of the model type.</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Get a specific instance of the model from the db by ID.
        /// </summary>
        /// <param name="id">ID of the object.</param>
        /// <returns>instance of model.</returns>
        T GetByID(object id);

        /// <summary>
        /// Queryable search of the db context for a list of IEnumerables of the model type.
        /// </summary>
        /// <param name="predicate"> search paramter <c>Where(x => x.matchID == 1)</c>.</param>
        /// <returns>IEnumerable of matching model instances.</returns>
        IEnumerable<T> Where(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Add an instance of the model to the DB.
        /// </summary>
        /// <param name="obj">Instance of the model.</param>
        void Add(T obj);

        /// <summary>
        /// Add a range of instances to the DB.
        /// </summary>
        /// <param name="objs">IEnumerable of the model.</param>
        void AddRange(IEnumerable<T> objs);

        /// <summary>
        /// Update an existing instance within the DB.
        /// </summary>
        /// <param name="obj">Instance to update.</param>
        void Update(T obj);

        /// <summary>
        /// Remove an existing instance from the DB.
        /// </summary>
        /// <param name="obj">Instance to remove.</param>
        void Remove(T obj);

        /// <summary>
        /// Remove a range of instances from the DB.
        /// </summary>
        /// <param name="objs">IEnumerable of instances to remove.</param>
        void RemoveRange(IEnumerable<T> objs);
    }
}
